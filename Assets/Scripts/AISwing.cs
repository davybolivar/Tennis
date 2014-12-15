using UnityEngine;
using System.Collections;

public class AISwing : MonoBehaviour {
	public GameObject aIRacket;

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Ball")
		{
			aIRacket.GetComponent<SwingRacket>().swingDir = !aIRacket.GetComponent<SwingRacket>().swingDir? true:false;
		}
	}
}
