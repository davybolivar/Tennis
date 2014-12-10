using UnityEngine;
using System.Collections;

public class CurveX : MonoBehaviour {
	public float dur;
	public float min, max;
	public GameObject ballCollider;

	// Use this for initialization
	void Start () {
		//min = ballCollider.transform.localPosition.y;
		//max = ballCollider.transform.localPosition.y + 1f;
	}
	
	// Update is called once per frame
	void Update () {
		dur = ballCollider.transform.rigidbody2D.velocity.x/3f;
		min = ballCollider.transform.localPosition.y;
		max = ballCollider.transform.localPosition.y + 1f;
		transform.position = new Vector3(ballCollider.transform.localPosition.x,  Mathf.PingPong(Time.time * dur, max-min)+min, transform.localPosition.z);
		//transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time * bodyDur, bodyMax-bodyMin)+bodyMin, body.transform.localPosition.z);
	}
}
