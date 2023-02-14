using System;
using System.Collections;
using System.Collections.Generic;
using Interaction;
using UnityEngine;

public class CarInteractionHandler : MonoBehaviour
{
	public void OnTriggerEnter2D(Collider2D col)
	{
		//Get an interactable, and interact with it!
		Interactable interact = col.gameObject.GetComponent<Interactable>();

		if (interact != null)
		{
			interact.Interact();
		}
	}
}
