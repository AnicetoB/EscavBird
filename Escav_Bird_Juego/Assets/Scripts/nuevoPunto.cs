using UnityEngine;
using System.Collections;

public class nuevoPunto : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D coll) {
		GameControl.score = GameControl.score+1;
		Debug.Log (GameControl.score);
	}
}
