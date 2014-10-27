using UnityEngine;
using System.Collections;

public class menuRestarScript : MonoBehaviour {

	Animator animacion_panel;
	
	// Use this for initialization
	void Start () {
		animacion_panel = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.dead) {
			animacion_panel.SetBool ("menuRestartOn", true);
			//if(Input.GetButtonDown("Jump")){
			//	restart();
			//}
		}
	}

	public void restart(){
		animacion_panel.SetBool ("menuRestartOn", false);
		Application.LoadLevel ("Nivel_unico");
		GameControl.dead = false;
	}

	public void quit(){
		Application.Quit ();
	}
}