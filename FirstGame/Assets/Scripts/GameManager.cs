using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool GameOver = false;
	public float delay = 2f;
	public GameObject complete;
	//new shit
	int losses = -1;
	//

	public void Won() {
		complete.SetActive(true);
	}

	public void EndGame() {
		if (GameOver == false) {
		 	GameOver = true;
		 	Invoke("Restart", delay);
		}
	}

	void Restart() {
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);      original shit
		losses = PlayerPrefs.GetInt("lose") + 1;
		PlayerPrefs.SetInt("lose", losses);

		PlayerPrefs.SetString("LastLoadedScene", SceneManager.GetActiveScene().name);
		SceneManager.LoadScene(5);
	}
}
