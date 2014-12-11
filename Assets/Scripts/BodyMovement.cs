using UnityEngine;
using System.Collections;

public class BodyMovement : MonoBehaviour {
	public GameObject head;
	public GameObject eyes;
	public GameObject hair;
	public GameObject hair2;
	public GameObject body;
	public GameObject leg1;
	public GameObject leg2;
	public GameObject lid1;
	public GameObject lid2;

	public GameObject playerObj;
	
	public GameObject headObj;

	public float legMax, legMin, rLegMax,rLegMin;
	public float legDur, rLegDur;

	public float bodyMax,bodyMin,bodyDur;

	public float hair1Max,hair2Max, hair1Min, hair2Min;
	public float hair1Dur,hair2Dur;

	public float lid1Max, lid1Min, lid2Max, lid2Min;
	public float lid1Dur, lid2Dur;

	public float headMax, headMin;
	public float headDur;

	void Start(){
		legMax = 60f;
		legMin = -30;

		rLegMax = 30f;
		rLegMin = -30f;

		bodyMax = 10f;
		bodyMin = -10f;

		hair1Max = 60f;
		hair1Min = -2f;
		hair2Max = 28f;
		hair2Min = 0f;

		lid1Max = 1.94f;
		lid1Min = 1f;
		lid2Max = 1.47f;
		lid2Min = 1f;

		headMax = .3f;
		headMin = 0f;
		headDur = 2f;
	}

	void Update(){
		if(playerObj.GetComponent<PlayerControls>().isMove)
		{	
			MoveAnim ();
		}
		else
		{
			IdleAnim ();
		}
	}

	void MoveAnim(){
		//Left and Right Leg
		leg1.transform.rotation = Quaternion.Euler(leg1.transform.localRotation.x, leg1.transform.localRotation.y,
		                                                                            Mathf.PingPong(Time.time * legDur, legMax-legMin)+legMin);
		leg2.transform.rotation = Quaternion.Euler(leg2.transform.localRotation.x, leg2.transform.localRotation.y,
		                                           Mathf.PingPong(Time.time * rLegDur, rLegMax-rLegMin)+rLegMin);

		//Body
		body.transform.rotation = Quaternion.Euler(body.transform.localRotation.x, body.transform.localRotation.y,
		                                           Mathf.PingPong(Time.time * bodyDur, bodyMax-bodyMin)+bodyMin);

		//Hair1 and Hair2
		hair.transform.rotation = Quaternion.Euler(hair.transform.localRotation.x, hair.transform.localRotation.y,
		                                           Mathf.PingPong(Time.time * hair1Dur, hair1Max-hair1Min)+hair1Min);
		hair2.transform.rotation = Quaternion.Euler(hair2.transform.localRotation.x, hair2.transform.localRotation.y,
		                                            Mathf.PingPong(Time.time * hair2Dur, hair2Max-hair2Min)+hair2Min);

		//Lid1 and Lid2
		lid1.transform.localScale = new Vector3(lid1.transform.localScale.x, Mathf.PingPong(Time.time * lid1Dur, lid1Max-lid1Min)+lid1Min,
		                                  		lid1.transform.localScale.z);
		lid2.transform.localScale = new Vector3(lid2.transform.localScale.x, Mathf.PingPong(Time.time * lid2Dur, lid2Max-lid2Min)+lid2Min,
		                                        lid2.transform.localScale.z);

		headObj.transform.localPosition = new Vector3 (Mathf.PingPong (Time.time * headDur, headMax - headMin) + headMin, headObj.transform.localPosition.y,
		                                              headObj.transform.localPosition.z);
	}

	void IdleAnim()
	{

		leg1.transform.rotation = Quaternion.Lerp(leg1.transform.rotation, Quaternion.Euler(new Vector3(leg1.transform.localRotation.x,leg1.transform.localRotation.y,0f)),.5f);
		leg2.transform.rotation = Quaternion.Lerp(leg2.transform.rotation, Quaternion.Euler(new Vector3(leg2.transform.localRotation.x,leg2.transform.localRotation.y,0f)),.5f);

		body.transform.rotation = Quaternion.Lerp(body.transform.rotation, Quaternion.Euler(new Vector3(body.transform.localRotation.x,body.transform.localRotation.y,0f)),.5f);

		hair.transform.rotation = Quaternion.Lerp(hair.transform.rotation, Quaternion.Euler(new Vector3(hair.transform.localRotation.x,hair.transform.localRotation.y,0f)),.5f);
		hair2.transform.rotation = Quaternion.Lerp(hair2.transform.rotation, Quaternion.Euler(new Vector3(hair2.transform.localRotation.x,hair2.transform.localRotation.y,0f)),.5f);
		
		lid1.transform.localScale = Vector3.Lerp(lid1.transform.localScale, new Vector3(lid1.transform.localScale.x,1f,lid1.transform.localScale.z),.5f);
		lid2.transform.localScale = Vector3.Lerp(lid2.transform.localScale, new Vector3(lid2.transform.localScale.x,1f,lid2.transform.localScale.z),.5f);

		headObj.transform.localPosition = Vector3.Lerp(headObj.transform.localPosition, new Vector3(0,headObj.transform.localPosition.y,
		                                                                                            headObj.transform.localPosition.z), .1f);
	}
	
}