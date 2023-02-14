using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class UIHUDPanel : UIPanel
{
	[SerializeField] private TMP_Text _timerText;
	void Update()
	{
		_timerText.text = _panelManager.GetRaceManager().GetRaceTimer().GetTime();
	}
}
