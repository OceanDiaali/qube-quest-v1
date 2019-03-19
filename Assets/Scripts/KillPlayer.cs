using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour {

	//public GameObject particleExplosion;
	//public GameObject blow;
	public Text EndGame;
	public int lives = 3;

	void Update() {
	}


	void OnCollisionEnter (Collision col) {
			if (col.gameObject.name == "Player") {
				Destroy (col.gameObject);
			    lives--;
			if (lives == 0) {
				//EndGame.text = "You lost!";
				//Time.timeScale = 0;
			} else {
				EndGame.text = "You lost!";
				Time.timeScale = 0;
			}
			    
				//Explode ();
			}
	}

//	void Explode () {
//		blow = Instantiate(particleExplosion, transform.position, Quaternion.identity);
//		Destroy (blow, 1);
//	}
}
