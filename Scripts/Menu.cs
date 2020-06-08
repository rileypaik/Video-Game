using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    // Call the function to start the game by loading the next scene
    public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
}
