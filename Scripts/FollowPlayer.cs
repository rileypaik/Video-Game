using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    // Get information from the player such as their position, rotation, and scale
    public Transform player;

    // Create an offset to go behind the player
    public Vector3 offset;
	
    // Update is called once per frame
    void Update () 
    {
	// Have the camera follow the player from behind
        transform.position = player.position + offset;	
    }
}
