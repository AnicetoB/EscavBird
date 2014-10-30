using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class nuevoPunto : MonoBehaviour {
	
	private Text textoP;
	private Text textoP2;

	void Start(){
		textoP = GameObject.Find ("textoNivel").GetComponent<Text> ();
		textoP.text = GameControl.score.ToString ();
		textoP2 = GameObject.Find ("puntos").GetComponent<Text> ();	
		textoP2.text = GameControl.score.ToString ();

	}

	void Update(){
		textoP.text = GameControl.score.ToString ();
		textoP2.text = GameControl.score.ToString ();
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Enemy" && !GameControl.dead){
			GameControl.score = GameControl.score + 1;
			//Debug.Log (GameControl.score);

		}
	}
}
