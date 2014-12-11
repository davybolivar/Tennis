using UnityEngine;
using System.Collections;

public class LerpTarget : MonoBehaviour {
	public GameObject target;
	public float offsetX, offsetY;
	public float duration;

	public float camOffset;
	void Update () {
		//if(transform.gameObject.name != "Main Camera")
		//{
			LerpToTarget ();
		/*}
		else
		{
			CamLerpToTarget();
		}
		*/
	}

	void CamLerpToTarget(){
		transform.localPosition = Vector3.Lerp (transform.localPosition, new Vector3((target.transform.localPosition.x*camOffset)+offsetX,
		                                                                             target.transform.localPosition.y+offsetY,
		                                                                             transform.localPosition.z),duration);
	}
	void LerpToTarget(){
		transform.localPosition = Vector3.Lerp (transform.localPosition, new Vector3(target.transform.localPosition.x+offsetX,
		                                                                             target.transform.localPosition.y+offsetY,
		                                                                             transform.localPosition.z),duration);
	}
}
