using UnityEngine;

public class EndTrigger : MonoBehaviour
{
	public GameManager manager;
	public PlayerMovement playerMove;

    void OnTriggerEnter() 
    {
    	if (playerMove.enabled == true) {
    		manager.Won();
    	}
    }
}
