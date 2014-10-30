using UnityEngine;
using System.Collections;

public class generadorCalabazas : MonoBehaviour {

	public GameObject columna;
	public float tiempodestroy = 3;
	public float mascalabazas = 0.01f;
	Vector3 posicion;
	float timer = 0;
	float timer2 = 1;
	public float limitcalabazas = 2.5f;
	public float tiempoespera = 1.5f;
	
	void Start () {
		posicion = transform.position;
		tiempoespera = 1.5f;
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

		//El timeSinceLevelLoad permite que al cargar de nuevo el nivel los tiempos se reinicien
		// fixedTime siempre se ejecuta, aunque el nivel sea reiniciado
		if (Mathf.Round (Time.timeSinceLevelLoad) > timer2) {
			timer2 = timer2 +1;
			tiempoespera = tiempoespera-mascalabazas;	
		}
	}
}