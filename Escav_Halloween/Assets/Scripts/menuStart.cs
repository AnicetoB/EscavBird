using UnityEngine;
using System.Collections;

public class menuStart : MonoBehaviour {

	

	void Update () {
		if (GameControl.dead) {
		}
	}
	
	public void restart(){
		Application.LoadLevel ("Nivel");
		GameControl.dead = false;
	}
	
	public void quit(){
		Application.Quit ();
	}
}