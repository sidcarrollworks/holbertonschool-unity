using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour {

	public Button menu;
	public Button next;
	// Use this for initialization
	void Start () {
		menu.onClick.AddListener(MainMenu);
		next.onClick.AddListener(Next);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MainMenu() {
		Time.timeScale = 1;
		SceneManager.LoadScene("MainMenu");
	}

	public void Next() {
		if (SceneManager.GetActiveScene().name == "Level03") {
			Time.timeScale = 1;
			SceneManager.LoadScene("MainMenu");
		} else {
			Time.timeScale = 1;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
