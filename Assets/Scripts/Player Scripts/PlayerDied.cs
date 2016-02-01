using UnityEngine;
using System.Collections;

public class PlayerDied : MonoBehaviour {

	public delegate void EndGame();
	public static event EndGame endGame;


	void PlayerDiedEndGame() {
	
		if (endGame != null) {
			endGame();
		}
		
		Destroy (gameObject);
	}




	/*
		Collector's collider is a trigger so can use OnTrigger
		Player and Zombie colliders are not triggers are we use OnCollision
	
	*/
	void OnTriggerEnter2D(Collider2D target) {
	
		if(target.tag == "Collector") {
			//PlayerDiedEndGame();
		}
	}


	// Use this for initialization
	void OnCollisionEnter2D(Collision2D target) {
		
		if(target.gameObject.tag == "Zombie") {
			//PlayerDiedEndGame();
		}
	
	}
	
	

	
}


















