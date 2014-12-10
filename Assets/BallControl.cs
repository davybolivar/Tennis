﻿using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {
	public GameObject camera;

	void Start () {
		hi (2.0f);
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
		}
		else 
		{
			rigidbody2D.AddForce(new Vector2(-100.0f,-20.0f));
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
		rigidbody2D.velocity = velocity;

		gameObject.transform.position = new Vector2 (0, 0);

		hi (0.5f);
		GoBall ();
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.collider.CompareTag("Player"))
		{
			var velY = rigidbody2D.velocity;
			velY.y = (velY.y/2.0f)+(col.collider.rigidbody2D.velocity.y/3.0f);
			rigidbody2D.velocity = velY;

			camera.GetComponent<LerpTarget>().camOffset *= -1f;
		}
	}
}
