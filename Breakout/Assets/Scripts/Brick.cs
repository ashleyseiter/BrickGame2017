﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	 
	public int health = 1;
	// Use this for initialization
	void start() {

	}
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D coll)
	{
		health -= 1; //	health -= 1 is the same as saying health = health -1;
		if (health == 0) {
			gameObject.SetActive (false); // when the collision happens you subract 1 from the health and when health is 0 it dissapears
		}
	}
}

