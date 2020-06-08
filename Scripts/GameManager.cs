using UnityEngine;
// Use to change scenes
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    // Called when the player completes the level
    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    {
        // Have the game only end once and restart the game
        if (gameHasEnded == false) 
        {
            gameHasEnded = true;
            // Add a slight delay when calling "Restart"
            Invoke("Restart", restartDelay);
        }

    }

    // Called to restart the scene
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
