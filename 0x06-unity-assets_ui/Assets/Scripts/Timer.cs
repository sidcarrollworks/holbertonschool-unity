using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text TimerText;
	float time;
	public GameObject endScreen;
	public GameObject endTime;
	public Camera gameCam;
	string tim;


	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		string sec = (time % 60).ToString("00.00");
		string min = Mathf.Floor((time % 3600)/60).ToString();
		TimerText.text = min + ":" + sec;
		tim = min + ":" + sec;
	}

	public void Win() {
		gameCam.GetComponent<CameraController>().enabled = false;
		endTime.GetComponent<Text>().text = tim;
		Time.timeScale = 0;
		Debug.Log("WIN!");
		endScreen.SetActive(true);
		TimerText.enabled = false;
	}
}
