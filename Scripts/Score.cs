using UnityEngine;
// Allows to write to the User Interface
using UnityEngine.UI;

public class Score : MonoBehaviour {

    // Get the player's position, rotation, and scale
    public Transform player;
    // Reference the text for the score
    public Text scoreText;
	
	// Update is called once per frame
	void Update () 
    	{
            // The score has to be a text, so convert the player's position to a string
            // Add the "0" so the score is only in whole numbers
            scoreText.text = player.position.z.ToString("0");
            if(scoreText.text == ("NaN"))
            {
                FindObjectOfType<GameManager>().EndGame();
            }
	}
}
