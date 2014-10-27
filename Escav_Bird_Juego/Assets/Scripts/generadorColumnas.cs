using UnityEngine;
using System.Collections;

public class generadorColumnas : MonoBehaviour {

	public GameObject columna;
	public float tiempoespera = 3;
	Vector3 posicion;
	float timer = 0;
	
	void Start () {
		posicion = transform.position;
	}

	void Update () {
		if (!GameControl.dead) {
			if (Time.time > timer) {
				var altura = Random.Range (0,0); 

				var nuevacolumna = (GameObject)Instantiate(
					columna,
					new Vector3 (posicion.x, posicion.y+altura,posicion.z),
					transform.rotation);
				Destroy(nuevacolumna, tiempoespera*100);
				timer = Time.time+tiempoespera;
			}
		}
	}
}