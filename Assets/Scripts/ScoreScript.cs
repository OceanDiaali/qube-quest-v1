using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Coin") {
			Destroy (col.gameObject);
		}

		if (col.gameObject.name == "Coin1") {
			Destroy (col.gameObject);
		}

		if (col.gameObject.name == "Coin2") {
			Destroy (col.gameObject);
		}
	}
}
