using UnityEngine;
using System.Collections;

public class LerpCircle : MonoBehaviour {

	public Vector3 target;
	public float duration;

	// Update is called once per frame
	void Update () {
		Invoke ("LerpSize",1f);
	}

	void LerpSize(){
		transform.localScale = Vector3.Lerp (transform.localScale, target,duration);
	}
}
