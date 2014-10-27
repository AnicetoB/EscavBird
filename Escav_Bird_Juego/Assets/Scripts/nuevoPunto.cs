using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class nuevoPunto : MonoBehaviour {
	
	private Text texto;

	void Start(){
		texto = GameObject.Find ("textoNivel").GetComponent<Text> ();
		
		texto.text = "Nivel " + GameControl.score.ToString ();
	}
	void OnTriggerEnter2D(Collider2D coll) {
		GameControl.score = GameControl.score + 1;
		//Debug.Log (GameControl.score);

		texto.text = "Nivel " + GameControl.score.ToString ();
	}
}
