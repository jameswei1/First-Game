using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit() {
    	if (PlayerPrefs.HasKey("lose") == true) {
    		PlayerPrefs.DeleteKey("lose");
    	}	
    }
    public void RestartGame() {
    	if (PlayerPrefs.HasKey("lose") == true) {
    		PlayerPrefs.DeleteKey("lose");
    	}
    	SceneManager.LoadScene("Level 1");
    }
}
