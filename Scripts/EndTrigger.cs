using UnityEngine;

public class EndTrigger : MonoBehaviour {

    // Reference the GameManager script
    public GameManager gameManager;

    // Detect if the player hits the finish line trigger
    void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();
    }
}
