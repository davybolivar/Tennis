using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	public GameObject target;
	public float speed;
	public float offset;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("RandomizeX",0,Random.Range(0,3f));
	}
	
	// Update is called once per frame
	void Update () {
		var step = speed * Time.deltaTime;
		
		// Move our position a step closer to the target.
		transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x,target.transform.localPosition.y+offset,
		                                                                         transform.position.z), speed*Time.deltaTime);
	}

	void RandomizeX(){
		offset = Random.Range (-1f, 1f);
	}
}
