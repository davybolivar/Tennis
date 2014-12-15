using UnityEngine;
using System.Collections;

public class LerpFrom : MonoBehaviour {
	public float toX,dur;

	// Update is called once per frame
	void Update () {
		LerpFromPos ();
	}

	void LerpFromPos(){
		transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(toX,transform.localPosition.y,transform.localPosition.z),
		                                       dur);
	}
}
