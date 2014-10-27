using UnityEngine;
using System.Collections;

public class jumpScript2 : MonoBehaviour {
	public float moveForce = 365f;            
	public float maxSpeed = 5f;            
	public float jumpForce = 1000f;
	public AudioClip jumpSound;
	public AudioClip deadSound;
	public bool jump = false;
	public GameObject personaje;
	public GameObject explosion;
	public float tiempoespera = 1;
	public GameObject menuDesplegable;
	public float giro = 1;
	public float movement = 1;
	
	// Use this for initialization
	
	Animator anim;
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump")&& !GameControl.dead){
			jump = true;
		}

		anim.SetBool("jump",jump); 
	
		if(Input.GetKey("left")) {
			transform.position = new Vector3 (transform.position.x-movement, transform.position.y, transform.position.z);
		}

		if(Input.GetKey("right")) {
			transform.position = new Vector3 (transform.position.x+movement, transform.position.y, transform.position.z);
		}

		if(Input.GetKey("up")) {
			transform.position = new Vector3 (transform.position.x, transform.position.y+movement, transform.position.z);
		}

		if(Input.GetKey("down")) {
			transform.position = new Vector3 (transform.position.x, transform.position.y-movement, transform.position.z);
		}
	}
	
	void FixedUpdate() {
		if(jump)
		{    
			var v = new Vector2(0,0);
			
			rigidbody2D.velocity = v; AudioSource.PlayClipAtPoint(jumpSound, transform.position);
			rigidbody2D.AddForce(new Vector2(0f, jumpForce));
			jump = false;
			
		}
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if(!GameControl.dead && col.gameObject.tag == "Enemy"){
			GameControl.dead = true;
			transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
			GameControl.score = 0;
		}
	}

}