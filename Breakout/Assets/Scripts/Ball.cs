using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

	public Vector2 startingVelocity = new Vector2(15, -20);
	private Vector3 startingPosition; 
	public GameObject gameoverSign;
	public GameObject youwinSign;// to make a layer of scene
	public Text livesValue;
	public Text pointsValue;


	int lives = 3;
	int points = 0;


	// Use this for initialization
	void Start () {
		startingPosition = transform.position;
		GetComponent<Rigidbody2D> ().velocity = startingVelocity;
		livesValue.text = lives.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -3.1f) { 
			GetOut ();
		}
		if(Input.GetButtonDown("Jump")) {
			GetComponent<Rigidbody2D> ().velocity = startingVelocity;
		}
	}
	

	void GetOut()
	{
		Debug.Log ("You are out");
		lives = lives - 1;
		livesValue.text = lives.ToString();


		transform.position = startingPosition;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 ();

		if (lives == 0) {
			DoGamerOver ();
		}

	}
	void DoGamerOver()
	{
		gameoverSign.SetActive (true);
	}
	public void YouBrokeABrick(int worth) // needs to be public so you can find it in brick script, worth is a var to change # of points per brick
	{
		points += worth;
		pointsValue.text = points.ToString();

		var bricksleft = FindObjectsOfType<Brick> ().Length; // This is how many/long bricks are left in the scene
		Debug.Log("bricksleft;"+ bricksleft);
		if(bricksleft == 0) {
			youwinSign.SetActive (true); // how to set the you win sign to come up when there are no bricks left
		}
	}
}
