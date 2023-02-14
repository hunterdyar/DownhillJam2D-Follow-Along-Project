using System;
using UnityEngine;

namespace Interaction
{
	public class Interactable : MonoBehaviour
	{
		private int _timesInteractedWith;
		protected virtual void Awake()
		{
			_timesInteractedWith = 0;
		}

		public virtual void Interact()
		{
			if (_timesInteractedWith == 0)
			{
				FirstInteraction();
			}
			_timesInteractedWith++;
		}

		protected virtual void FirstInteraction()
		{
			
		}
	}
}