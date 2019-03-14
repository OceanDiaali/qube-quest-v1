using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour {

	//public GameObject particleExplosion;
	//public GameObject blow;
	public Text EndGame;

	void Update() {
	}


	void OnCollisionEnter (Collision col) {
			if (col.gameObject.name == "Player") {
				Destroy (col.gameObject);
			    EndGame.text = "You lost!";
			    Time.timeScale = 0;
				//Explode ();
			}
	}

//	void Explode () {
//		blow = Instantiate(particleExplosion, transform.position, Quaternion.identity);
//		Destroy (blow, 1);
//	}
}
