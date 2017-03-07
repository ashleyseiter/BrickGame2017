using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	 
	int lives = 2;
	// Use this for initialization
	void start() {

	}
	// Update is called once per frame
	void Update() {
		lives = lives - 1;
		if (lives == 0) {
			OnCollisionEnter2D (Collision2D coll);
		}
	
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		gameObject.SetActive(false);
	}
}

