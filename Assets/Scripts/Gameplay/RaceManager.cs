using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceManager : MonoBehaviour
{
    [SerializeField] private float startTime;
    //Timer
    private Timer _timer;

    private RaceState _raceState;

    private void Awake()
    {
        _raceState = RaceState.Countdown;
        _timer = new Timer();
    }

    void Start()
    {
        StartRace();
    }
    
    void StartRace()
    {
        _raceState = RaceState.Racing;
        _timer.InitiateTimer(startTime);
    }
    
    void Update()
    {
        //if the game is in gameplay state...
        if (_raceState == RaceState.Racing)
        {
            _timer.TickTimer();
            //check if time has run out.
            if (_timer.IsTimeUp())
            {
                //go to lose state!
                Debug.Log("Time Is Up!");
                _raceState = RaceState.Lost;
            }
        }
    }

    public void AddRaceTime(float timeToAdd)
    {
        if (_raceState == RaceState.Racing)
        {
            Debug.Log("Time Added!");
            _timer.AddTime(timeToAdd);
        }
        else
        {
            Debug.Log("Time cant be added because state is "+ _raceState);
        }
    }

    //called by player when at the finish line
    public void WinGame()
    {
        Debug.Log("We win!");
        _raceState = RaceState.Won;
    }

    public Timer GetRaceTimer()
    {
        return _timer;
    }

    public RaceState GetRaceState()
    {
        return _raceState;
    }
}
