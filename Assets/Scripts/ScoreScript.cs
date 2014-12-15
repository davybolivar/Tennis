using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	public Text text;
	int score;
	public string tag;
	public GameObject mainCamera;

	void Start(){
		score = 0;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == tag)
		{
			score++;
			//text.gameObject.GetComponent<Text>().text = ""+score;
			text.text = score.ToString();
			Debug.Log(score);
			mainCamera.GetComponent<ScreenShake>().Shake(.05f);
		}
	}
}
