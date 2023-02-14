using System;
using UnityEngine;

namespace Interaction
{
	public class Checkpoint : Interactable
	{
		[SerializeField] private RaceManager _raceManager;
		[SerializeField] private float timeToGain = 30;
		
		protected override void FirstInteraction()
		{
			_raceManager.AddRaceTime(timeToGain);
		}
	}
}