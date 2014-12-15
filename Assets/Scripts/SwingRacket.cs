using UnityEngine;
using System.Collections;

public class SwingRacket : MonoBehaviour {
	public float startSwing,endSwing;
	public float speed;
	public bool swingDir;

	void Start(){
		swingDir = true;
	}

	void Update(){
		if(swingDir)
		{
			SwingDown ();
			swingDir = true;
		}
		else
		{
			SwingUp();
			swingDir = false;
		}
	}

	public void SwingDown(){
		transform.localRotation = Quaternion.Lerp (transform.localRotation,Quaternion.Euler(transform.localRotation.x,
		                                                                               transform.localRotation.y,
		                                                                               endSwing),speed);
	}
	public void SwingUp(){
		transform.localRotation = Quaternion.Lerp (transform.localRotation,Quaternion.Euler(transform.localRotation.x,
		                                                                                    transform.localRotation.y,
		                                                                                    startSwing),speed);                                          
	}

}
