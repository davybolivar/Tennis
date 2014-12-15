using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
		
	public void Play(){
		Application.LoadLevel ("Play");
	}

	public void MainMenu()
	{
		Application.LoadLevel ("Menu");
	}

}
