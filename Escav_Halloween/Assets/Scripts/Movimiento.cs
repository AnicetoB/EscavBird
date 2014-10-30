using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	public int vhorizontal = 1;
	public int vvertical = 1;
	Vector3 movimiento;
	Vector3 posicionRaton;
	Animator animation; 

	void Start(){
		animation = GetComponent <Animator> ();
		//Al inicializar cargamos las variables de las animaciones
	}
	
	void Update() {

		if (!GameControl.dead && !GameControl.limit) {
				posicionRaton = Input.mousePosition;

				posicionRaton = Camera.main.ScreenToWorldPoint (posicionRaton);

				if (Input.GetMouseButton (0)) {
					transform.position = Vector2.Lerp (transform.position, posicionRaton, vvertical * 0.1f);
					animation.SetBool ("Escavillo_mov", true);

				} else if (Input.GetMouseButtonUp (0)) {
					animation.SetBool ("Escavillo_mov", false);
				}


		}

	}

	void OnCollisionEnter2D(Collision2D col){
	if (col.gameObject.tag == "Enemy")
		if(!GameControl.dead){
		GameControl.dead = true;
			transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
			rigidbody2D.gravityScale = 2;
		}

	}


}