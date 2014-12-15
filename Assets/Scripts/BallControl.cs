﻿using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {
	public GameObject camera;
	public GameObject ballSprite;
	public int ballServe;
	public bool replay;
	public GameObject p1,p2;

	//Effects
	public GameObject shine;

	void Start () {
		StartCoroutine ("StartGame");
		//hi (5.0f);
		//GoBall ();
	}

	IEnumerator StartGame()
	{
		yield return new WaitForSeconds(3.0f);
		GoBall ();
		
	}

	IEnumerator hi(float secs)
	{
		yield return new WaitForSeconds(secs);
	}

	void GoBall(){
		float rand = Random.Range (0.0f,100f);
		if(rand < 50.0f)
		{
			rigidbody2D.AddForce(new Vector2(100.0f,20.0f));
			ballServe = 1;
		}
		else 
		{
			rigidbody2D.AddForce(new Vector2(-100.0f,-20.0f));
			ballServe = 2;
		}
	}

	void hasWon(){
		var velocity = rigidbody2D.velocity;
		velocity.y = 0;
		velocity.x = 0;
		rigidbody2D.velocity = velocity;

		gameObject.transform.position = new Vector2 (0,0);
	}

	void resetBall(){
		var velocity = rigidbody2D.velocity;
		velocity.y = 0;
		velocity.x = 0;
		rigidbody2D.mass = .25f;
		rigidbody2D.velocity = velocity;
		gameObject.transform.position = new Vector2 (0, 0);

		hi (5.0f);
		GoBall ();
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.collider.CompareTag("Player"))
		{
			var velY = rigidbody2D.velocity;
			velY.y = (velY.y/2.0f)+(col.collider.rigidbody2D.velocity.y/3.0f);
			rigidbody2D.velocity = velY;

			rigidbody2D.mass -= .01f;

			camera.GetComponent<LerpTarget>().camOffset *= -1f;

			if(ballServe == 1)
				ballServe = 2;
			else
				ballServe = 1;
		}
		else if(col.gameObject.tag == "P1Goal" || col.gameObject.tag == "P2Goal")
		{
			Instantiate(shine);
			//resetBall();
			StartCoroutine("ReplayDelay");
		}
		else if(col.gameObject.tag == "Out")
		{
			StartCoroutine("ReplayDelay");
		}
	}

	IEnumerator ReplayDelay()
	{	
		replay = true;
		ballServe = 1;
		camera.transform.position = Vector3.Lerp (camera.transform.localPosition, new Vector3(0,0,camera.transform.localPosition.z),.1f);
		ballSprite.GetComponent<TrailRenderer> ().enabled = false;
		hasWon ();
		yield return new WaitForSeconds (3f);
		ballSprite.GetComponent<TrailRenderer> ().enabled = true;
		replay = false;
		resetBall();
	}
}
