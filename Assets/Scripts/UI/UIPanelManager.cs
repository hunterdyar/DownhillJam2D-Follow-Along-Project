using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//turn on and off UI gameObjects according to the game state.
public class UIPanelManager : MonoBehaviour
{
    private RaceState _displayState;
    [SerializeField] private RaceManager _raceManager;
    
    //
    [SerializeField] private UIPanel HUDPanel;
    [SerializeField] private UIPanel TimeUpPanel;
    [SerializeField] private UIPanel WinPanel;

    private void Awake()
    {
        //dependency injection pattern.
        HUDPanel.InitPanel(this);
        TimeUpPanel.InitPanel(this);
        WinPanel.InitPanel(this);
    }

    void Update()
    {
        if (_displayState != _raceManager.GetRaceState())
        {
            _displayState = _raceManager.GetRaceState();

            HUDPanel.SetPanelActive(_displayState == RaceState.Racing);
            TimeUpPanel.SetPanelActive(_displayState == RaceState.Lost);
            WinPanel.SetPanelActive(_displayState == RaceState.Won);
        }
    }

    public RaceManager GetRaceManager()
    {
        return _raceManager;
    }
}
