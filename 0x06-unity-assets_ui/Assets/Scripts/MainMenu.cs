using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class MainMenu : MonoBehaviour {

	public Button level1;
	public Button level2;
	public Button level3;
	public Button ExitBtn;
	public Button OptionBtn;
	// Use this for initialization
	void Start () {
		level1.onClick.AddListener(delegate{LevelSelect(1);});
		level2.onClick.AddListener(delegate{LevelSelect(2);});
		level3.onClick.AddListener(delegate{LevelSelect(3);});
		OptionBtn.onClick.AddListener(Options);
		ExitBtn.onClick.AddListener(Exit);
	}

	public void LevelSelect(int level) {
		SceneManager.LoadScene("level"+level.ToString("00"));
	}

	public void Options() {
		SceneManager.LoadScene("Options");
	}

	public void Exit() {
		Debug.Log("Exited");
		Application.Quit();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
