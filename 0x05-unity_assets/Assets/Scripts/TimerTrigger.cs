using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour {

	public GameObject Player;
	
	void OnTriggerExit(Collider other) {
		Player.GetComponent<Timer>().enabled = true;
	}
}
