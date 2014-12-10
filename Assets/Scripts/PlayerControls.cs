using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
	public KeyCode moveUp = KeyCode.UpArrow;
	public KeyCode moveDown = KeyCode.DownArrow;

	public float speed = 10.0f;
	//public float velocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PlayerActions ();
	}

	void PlayerActions(){
		if(Input.GetKey(moveUp))
		{
			var velocity = rigidbody2D.velocity;
			velocity.y = speed;
			rigidbody2D.velocity = velocity;
		}
		else if(Input.GetKey(moveDown))
		{
			var velocity = rigidbody2D.velocity;
			velocity.y = -1*speed;
			rigidbody2D.velocity = velocity;
		}
		else if(!Input.anyKey)
		{
			var velocity = rigidbody2D.velocity;
			velocity.y = 0.0f;
			rigidbody2D.velocity = velocity;
		}

		var reset = rigidbody2D.velocity;
		reset.x = 0;
		rigidbody2D.velocity = reset;
	}
}
