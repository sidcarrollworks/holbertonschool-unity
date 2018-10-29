using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text TimerText;
	float time;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		string sec = (time % 60).ToString("00.00");
		string min = Mathf.Floor((time % 3600)/60).ToString();
		TimerText.text = min + ":" + sec;
	}
}
