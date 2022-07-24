using UnityEngine;

public class EndTrigger : MonoBehaviour {
	public GameManager gameManager;

	void OnCollisionEnter(Collision collisionInfo){
		if (collisionInfo.collider.name == "Player") {
			gameManager.CompleteLevel ();
			Debug.Log ("game won! in onTriggerEnter function");
		}
	}
}