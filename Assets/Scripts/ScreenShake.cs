using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour 
{
	
	Vector3 originalCameraPosition;
	
	float shakeAmt = 0;
	
	public Camera mainCamera;
	
	void Awake(){
		originalCameraPosition = mainCamera.transform.position;
	}
	
	public void Shake(float amt)
	{
		mainCamera.transform.position = originalCameraPosition;
		shakeAmt = amt;
		InvokeRepeating("CameraShake", 0, .01f);
		Invoke("StopShaking", 0.2f);
	}
	
	void CameraShake()
	{
		if(shakeAmt>0) 
		{
			float quakeAmt = Random.value*shakeAmt*2 - shakeAmt;
			Vector3 pp = mainCamera.transform.position;
			pp.y+= quakeAmt; // can also add to x and/or z
			pp.x+= quakeAmt; // can also add to x and/or z
			mainCamera.transform.position = pp;
		}
	}
	
	void StopShaking()
	{
		CancelInvoke("CameraShake");
		mainCamera.transform.position = originalCameraPosition;
	}
	
}
