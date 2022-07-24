
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	public PlayerMovement movement;
	// public GameManager gameManager;

	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.collider.tag == "Obstacle"){
			Debug.Log ("we hit an Obstacle!");
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
