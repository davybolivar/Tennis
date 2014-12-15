using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	public GameObject target;
	public float speed;
	public float offset;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("RandomizeX",2,Random.Range(0,2f));
	}
	
	// Update is called once per frame
	void Update () {
		if(target.GetComponent<BallControl>().ballServe == 2)
		{
			if(target.transform.localPosition.y <= 4 && target.transform.localPosition.y >= -4.5)
			{
			var step = speed * Time.deltaTime;
			// Move our position a step closer to the target.
			transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x,target.transform.localPosition.y+offset,
		                                                                      transform.position.z), speed*Time.deltaTime);
			}
		}
	}

	void RandomizeX(){
		offset = Random.Range (-1f, 1f);
	}
}
