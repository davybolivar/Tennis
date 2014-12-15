using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {

	public void PlayButton(){
		Application.LoadLevel ("Play");
	}

	public void MenuButton(){
		Application.LoadLevel ("Menu");
	}

}