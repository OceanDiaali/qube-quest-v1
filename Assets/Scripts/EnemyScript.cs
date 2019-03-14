using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	//public Transform[] target;
	public float speed = 5f;


	//CountDownScript checkTime;

	//private int current;

	
	// Update is called once per frame
	void Update () {
//		if (transform.position != target [current].position) {
//			Vector3 pos = Vector3.MoveTowards (transform.position, target [current].position, speed * Time.deltaTime);
//			GetComponent<Rigidbody> ().MovePosition (pos);
//		} else {
//			current = (current + 1) % target.Length;
//		}
		//transform.position = new Vector3(Mathf.PingPong(Time.time, 2), transform.position.y, transform.position.z);
		transform.position = new Vector3(Mathf.PingPong(Time.time, 1), transform.position.y, Mathf.PingPong(Time.time, 2) * speed);
	}
}
