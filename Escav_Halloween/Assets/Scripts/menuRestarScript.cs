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
			animacion_panel.SetBool ("MenuRest", true);
		}
	}

	public void restart(){
		animacion_panel.SetBool ("MenuRest", false);
		GameControl.dead = false;
		GameControl.score = 0;
		Application.LoadLevel (Application.loadedLevel);
	}

	public void quit(){
		Application.Quit ();
	}
}