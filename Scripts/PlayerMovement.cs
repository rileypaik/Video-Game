using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Reference the Rigidbody component
    public Rigidbody rb;

    // Reference the fowardForce and sidewaysForce to modify them easily
    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;

    // use Time.deltaTime to even out frame rates on different devices.
    // Use FixedUpdate to implement physics.
    void FixedUpdate () {

        // Add the forward force
        rb.AddForce(0, 0, fowardForce*Time.deltaTime);

        // If the player presses the "d" key, move to the right
        if(Input.GetKey("d"))
        {
            // Use ForceMode.VelocityChange to make the movement more responsive
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // If the player presses the "a" key, move to the left
        if (Input.GetKey("a"))
        {
            // Use ForceMode.VelocityChange to make the movement more responsive
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // If the player falls of the edge, end the game by calling the "EndGame" function
        // in the "GameManager" script
        if (rb.position.y <-1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
