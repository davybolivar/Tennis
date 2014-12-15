using UnityEngine;
using System.Collections;

public class LerpRotation : MonoBehaviour {
	public float targetZ;
	public float dur;

	public GameObject trigger;

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
