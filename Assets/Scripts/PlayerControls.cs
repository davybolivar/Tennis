using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
	public KeyCode moveUp = KeyCode.UpArrow;
	public KeyCode moveDown = KeyCode.DownArrow;

	public float colliderOff, timer;

	public bool isHitting;

	public bool isMove; 
	
	public float speed = 10.0f;

	public GameObject racket;
	//public float velocity;

	// Use this for initialization
	void Start () {
		timer = 0f;
		colliderOff = 1f;
		transform.collider2D.enabled = false;
		isMove = false;
	}
	
	// Update is called once per frame
	void Update () {
		PlayerActions ();
	}

	void PlayerActions(){
		if(isHitting)
		{
			if(timer >= colliderOff)
			{
				transform.collider2D.enabled = false;
				timer = 0;
			}
			else
			{
				timer += Time.deltaTime;
			}
		}
		var reset = rigidbody2D.velocity;
		reset.x = 0;
		rigidbody2D.velocity = reset;

	}

	public void Up(){
		isMove = true;
		var velocity = rigidbody2D.velocity;
		velocity.y = speed;
		rigidbody2D.velocity = velocity;
	}
	public void Down(){
		isMove = true;
		var velocity = rigidbody2D.velocity;
		velocity.y = -1*speed;
		rigidbody2D.velocity = velocity;
	}
	public void Hit(){
		isHitting = true;
		//racket.GetComponent<SwingRacket>().swingDir = !racket.GetComponent<SwingRacket>().swingDir? true:false; 
		StartCoroutine ("DelaySwing");
		transform.collider2D.enabled = true;
	}
	public void Reset(){
		isMove = false;
		var velocity = rigidbody2D.velocity;
		velocity.y = 0.0f;
		rigidbody2D.velocity = velocity;
	}

	IEnumerator DelaySwing(){
		yield return new WaitForSeconds(.1f);
		racket.GetComponent<SwingRacket>().swingDir = !racket.GetComponent<SwingRacket>().swingDir? true:false; 
	}
}
