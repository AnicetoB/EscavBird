using UnityEngine;
using System.Collections;

public class gameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	public void Salir(){
		Application.Quit (); //Aplication sirve para cosas generales del juego/aplicaciona
	}

	public void Reiniciar(){
		GameControl.dead = false;
		Application.LoadLevel ("Nivel_unico");
	}

	public void Iniciar() {
		Application.LoadLevel ("Nivel_unico");
	}
}
