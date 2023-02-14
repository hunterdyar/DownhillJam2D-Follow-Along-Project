using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer 
{
	//its own lil' thing
	private float _timer;
	
	//Ticking it each frame
	//Comparing start and end times.
	public void InitiateTimer(float totalTime)
	{
		_timer = totalTime;
	}

	//Should be called in Update.
	public void TickTimer()
	{
		_timer = Mathf.Max((_timer - Time.deltaTime),0);
	}

	public bool IsTimeUp()
	{
		return _timer <= 0;
	}

	public void AddTime(float timeToAdd)
	{
		_timer = _timer + timeToAdd;
	}

	public string GetTime()
	{
		return Mathf.Ceil(_timer).ToString("N0");
	}
}
