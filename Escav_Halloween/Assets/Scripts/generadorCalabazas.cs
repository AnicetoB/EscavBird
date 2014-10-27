using UnityEngine;
using System.Collections;

public class generadorCalabazas : MonoBehaviour {

	public GameObject columna;
	public float tiempoespera = 3;
	public float tiempodestroy = 3;
	public float mascalabazas = 0.01f;
	Vector3 posicion;
	float timer = 0;
	float timer2 = 1;
	public float limitcalabazas = 2.5f;
	
	void Start () {
		posicion = transform.position;
	}

	void Update () {
		if (Time.time > timer) {
			var phorizontal = Random.Range (limitcalabazas*-1,limitcalabazas); 
			var nuevacolumna = (GameObject)Instantiate(
				columna,
				new Vector3 (posicion.x+phorizontal, posicion.y,posicion.z),
				transform.rotation);
			Destroy(nuevacolumna, tiempodestroy);
			timer = Time.time+tiempoespera;
		}

		if (Mathf.Round (Time.fixedTime) > timer2) {
			timer2 = timer2 +1;
			tiempoespera = tiempoespera-mascalabazas;	
		}
	}
}