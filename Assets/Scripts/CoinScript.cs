using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	public float rotationSpeed = 100f;

	// Update is called once per frame
	void Update()
	{
		//distance (in angles) to rotate on each frame. distance = speed * time
		float angle = rotationSpeed * Time.deltaTime;

		//rotate on Y
		transform.Rotate(Vector3.up * angle, Space.World);
	}

	void OnCollisionEnter (Collision coll) {
		if (coll.gameObject.name == "Coin") {
			Destroy (coll.gameObject);
		} 
		if (coll.gameObject.name == "Coin1") {
			Destroy (coll.gameObject);
		} 
		if (coll.gameObject.name == "Coin2") {
			Destroy (coll.gameObject);
		}
	}
}
