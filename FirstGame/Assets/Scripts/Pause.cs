using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pause : MonoBehaviour
{
	public static bool IsPaused = false;
	public GameObject PauseMenu;

	void Update() {
		if (Input.GetKeyDown("p")) {
			if (IsPaused) {
				ResumeGame();
			}
			else {
				PauseGame();
			}
		}
		
	}

	void PauseGame() {
		PauseMenu.SetActive(true);
		Time.timeScale = 0f;
		IsPaused = true;
	}

	void ResumeGame() {
		PauseMenu.SetActive(false);
		Time.timeScale = 1f;
		IsPaused = false;
	}
}
