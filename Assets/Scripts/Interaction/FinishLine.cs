using Interaction;
using UnityEngine;

public class FinishLine : Interactable
{
	[SerializeField] private RaceManager _raceManager;

	protected override void FirstInteraction()
	{
		_raceManager.WinGame();
	}
}