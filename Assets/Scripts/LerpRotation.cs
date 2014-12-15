using UnityEngine;
using System.Collections;

public class LerpRotation : MonoBehaviour {
	public float targetZ;
	public float minRange, maxRange;
	public float dur;

	public GameObject trigger;

	void Start(){
		targetZ = Random.Range (minRange,maxRange);
	}

	void Update () {
		if(trigger.GetComponent<TriggerEffects>().trigger)
		{
			LerpRotate();
		}
	}

	void LerpRotate(){
		transform.localRotation = Quaternion.Lerp (transform.localRotation,Quaternion.Euler(new Vector3(transform.localRotation.x,
		                                                                                                transform.localRotation.y,
		                                                                                                targetZ)),dur);
	}
}
