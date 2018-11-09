using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public GameObject pauseScreen;
	public Camera camera;
	public Button restartBtn;
	public Button menuBtn;
	public Button resumeBtn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (!pauseScreen.activeInHierarchy) {
				Pause();
			} else if (pauseScreen.activeInHierarchy) {
				Resume();
			}
		}
	}

	public void Pause() {
		camera.GetComponent<CameraController>().enabled = false;
		Time.timeScale = 0;
		pauseScreen.SetActive(true);
		restartBtn.onClick.AddListener(Restart);
		menuBtn.onClick.AddListener(MainMenu);
		resumeBtn.onClick.AddListener(Resume);
	}

	public void Resume() {
		camera.GetComponent<CameraController>().enabled = true;
		Time.timeScale = 1;
		pauseScreen.SetActive(false);
	}

	public void Restart() {
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void MainMenu() {
		Time.timeScale = 1;
		SceneManager.LoadScene("MainMenu");
	}
}
