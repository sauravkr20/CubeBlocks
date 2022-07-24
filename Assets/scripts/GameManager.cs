using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {
	bool gameHasEnded= false;
	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	public void CompleteLevel(){
		Debug.Log ("Level won!");
		completeLevelUI.SetActive (true);
	}


	public void EndGame(){
		if (gameHasEnded == false) {
			Debug.Log("end of the game!");
			gameHasEnded = true;
			Invoke ("Restart", restartDelay);
		}
	}

	void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
