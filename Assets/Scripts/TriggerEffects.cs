using UnityEngine;
using System.Collections;

public class TriggerEffects : MonoBehaviour {

	public bool trigger;
	public float sec;

	void Start(){
		sec = 1.5f;
	}

	void Update(){
		Destroy ();
	}

	void Destroy(){
		Destroy (transform.gameObject,sec);
	}
}
