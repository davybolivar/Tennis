using UnityEngine;
using System.Collections;

public class LerpSize : MonoBehaviour {

	public float targetX;
	public float targetY;
	public float dur;

	public GameObject trigger;
	
	// Update is called once per frame
	void Update () {
		if(trigger.GetComponent<TriggerEffects>().trigger)
		{
			LerpToSize();
		}
	}

	void LerpToSize(){
		transform.localScale = Vector3.Lerp (transform.localScale, new Vector3(targetX, targetY, transform.localScale.z), dur);
	}
}
