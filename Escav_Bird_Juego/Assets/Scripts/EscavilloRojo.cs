using UnityEngine;
using System.Collections;

public class EscavilloRojo : MonoBehaviour {

	public GameObject enemigo;
	
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Player"){
			this.collider2D.enabled = false;
			Destroy (enemigo, 0);
		}
	}
}
