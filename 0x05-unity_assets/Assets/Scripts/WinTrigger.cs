using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour {

	public Text TimerText;
	public GameObject Player;

	void OnTriggerEnter(Collider other) {
		Player.GetComponent<Timer>().enabled = false;
		TimerText.fontSize = 36;
		TimerText.color = Color.green;
	}
}
