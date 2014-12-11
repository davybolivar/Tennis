using UnityEngine;
using System.Collections;

public class P2BodyMovement : MonoBehaviour {
	public GameObject head;
	public GameObject eyes;
	public GameObject hair;
	public GameObject ribbon;
	public GameObject body;
	public GameObject leg1;
	public GameObject leg2;
	
	public GameObject playerObj;
	
	public GameObject headObj;
	
	public float legMax, legMin, rLegMax,rLegMin;
	public float legDur, rLegDur;
	
	public float bodyMax,bodyMin,bodyDur;
	
	public float hair1Max, hair1Min;
	public float hair1Dur;
	
	public float headMax, headMin;
	public float headDur;

	public float ribbonMax, ribbonMin;
	public float ribbonDur;
	
	void Start(){
		legMax = 60f;
		legMin = -30;
		
		rLegMax = 30f;
		rLegMin = -30f;
		
		bodyMax = 10f;
		bodyMin = -10f;
		
		hair1Max = 60f;
		hair1Min = -2f;
		
		headMax = .3f;
		headMin = 0f;
		headDur = 2f;

		ribbonMax = 10f;
		ribbonMin = -10f;
	}
	
	void Update(){
		Debug.Log (playerObj.transform.rigidbody2D.velocity.y);
		/*if(playerObj.GetComponent<PlayerControls>().isMove)
		{	
			MoveAnim ();
		}
		else
		{
			IdleAnim ();
		}*/
		//if(gameObject.rigidbody2D.velocity.y > 0f)
		//{	
			MoveAnim ();
		//}
		//else
		//{
		//	IdleAnim ();
		//}
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
		
		//Hair1
		hair.transform.rotation = Quaternion.Euler(hair.transform.localRotation.x, hair.transform.localRotation.y,
		                                           Mathf.PingPong(Time.time * hair1Dur, hair1Max-hair1Min)+hair1Min);

		//Ribbon
		ribbon.transform.rotation = Quaternion.Euler(ribbon.transform.localRotation.x, ribbon.transform.localRotation.y,
		                                             Mathf.PingPong(Time.time * ribbonDur, ribbonMax-ribbonMin)+ribbonMin);
		
		headObj.transform.localPosition = new Vector3 (Mathf.PingPong (Time.time * headDur, headMax - headMin) + headMin, headObj.transform.localPosition.y,
		                                               headObj.transform.localPosition.z);
	}
	
	void IdleAnim()
	{
		
		leg1.transform.rotation = Quaternion.Lerp(leg1.transform.rotation, Quaternion.Euler(new Vector3(leg1.transform.localRotation.x,leg1.transform.localRotation.y,0f)),.5f);
		leg2.transform.rotation = Quaternion.Lerp(leg2.transform.rotation, Quaternion.Euler(new Vector3(leg2.transform.localRotation.x,leg2.transform.localRotation.y,0f)),.5f);
		
		body.transform.rotation = Quaternion.Lerp(body.transform.rotation, Quaternion.Euler(new Vector3(body.transform.localRotation.x,body.transform.localRotation.y,0f)),.5f);
		
		hair.transform.rotation = Quaternion.Lerp(hair.transform.rotation, Quaternion.Euler(new Vector3(hair.transform.localRotation.x,hair.transform.localRotation.y,0f)),.5f);

		ribbon.transform.rotation = Quaternion.Lerp(ribbon.transform.rotation, Quaternion.Euler(new Vector3(ribbon.transform.localRotation.x,ribbon.transform.localRotation.y,0f)),.5f);
		
		headObj.transform.localPosition = Vector3.Lerp(headObj.transform.localPosition, new Vector3(0,headObj.transform.localPosition.y,
		                                                                                            headObj.transform.localPosition.z), .1f);
	}
	
}