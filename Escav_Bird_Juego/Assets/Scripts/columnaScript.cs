using UnityEngine;
using System.Collections;

public class columnaScript : MonoBehaviour {
	
	public int vhorizontal = -1;
	Vector3 movimiento;
	
	void Update() {
		if (!GameControl.dead) {
		movimiento = new Vector3 (vhorizontal, 0, 0);
		transform.Translate (movimiento * Time.deltaTime);
		}
	}
}