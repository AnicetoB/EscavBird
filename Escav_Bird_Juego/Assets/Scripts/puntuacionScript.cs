using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class puntuacionScript : MonoBehaviour {
		
	private Text textoP;
		
	void Start(){
		textoP = GameObject.Find ("textoPuntuacion").GetComponent<Text> ();
		textoP.text = "Puntuacion - " + GameControl.score.ToString ();
	}
	void OnTriggerEnter2D(Collider2D coll) {			
		textoP.text = "Puntuacion - " + GameControl.score.ToString ();
		}
	}
