using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    // Reference the PlayerMovement script
    public PlayerMovement movement;

    // Built-in Unity function that is called when the player collides with something
    void OnCollisionEnter (Collision collisionInfo)
    {
        // If the collider the player hit is an obstacle, turn off the PlayerMovement
        // script and end the game by calling the "EndGame" function in the "GameManager"
        // script. 
        if (collisionInfo.collider.tag == "Obstacle") 
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
