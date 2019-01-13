using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame() {
    	SceneManager.LoadScene("Level 1");
        Time.timeScale = 1f;
        if (PlayerPrefs.HasKey("lose") == true) {
            PlayerPrefs.DeleteKey("lose");
        }
    }
    public void DrawMenu() {
        SceneManager.LoadScene("Menu");
    }
    public void DrawInstructions() {
        SceneManager.LoadScene("Instructions");
    }
    public void DrawHS() {
        SceneManager.LoadScene("HighScores");
    }

    //Extra shit
    //Reloads current scene for when you lose
    public void RestartLevel() {
    	string sceneName = PlayerPrefs.GetString("LastLoadedScene");
    	SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }

    public void RestartGame() {
        SceneManager.LoadScene("Menu");
        if (PlayerPrefs.HasKey("lose") == true) {
            PlayerPrefs.DeleteKey("lose");
        }
    }
    //
}
