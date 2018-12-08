using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement stopMoving;
	void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
            stopMoving.enabled = false;
            FindObjectOfType<GameManager>().endGame();
        }
        
    }

}
