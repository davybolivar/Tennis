using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LerpColor : MonoBehaviour {
	public Color targetColor;
	public float dur;

	void Start(){
		//Invoke ("LerpColorScript",3f);
	}

	// Update is called once per frame
	void Update () {
		Invoke ("LerpColorScript",2f);
	}

	void LerpColorScript(){
		transform.GetComponent<Text>().color = Color.Lerp(transform.GetComponent<Text>().color, targetColor, dur);
	}
}
