using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	public int vhorizontal = 1;
	public int vvertical = 1;
	Vector3 movimiento;
	Vector3 posicionRaton;

	void Update() {

		posicionRaton = Input.mousePosition;

		posicionRaton = Camera.main.ScreenToWorldPoint (posicionRaton);

		if (Input.GetMouseButton (0)) {
		transform.position = Vector2. Lerp (transform.position, posicionRaton, vvertical*0.1f);
		}

	}

}