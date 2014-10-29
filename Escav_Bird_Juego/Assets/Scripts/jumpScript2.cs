using UnityEngine;
using System.Collections;

public class jumpScript2 : MonoBehaviour {
	public float moveForce = 365f;            
	public float maxSpeed = 5f;            
	public float jumpForce = 1000f;
	public AudioClip jumpSound;
	public AudioClip deadSound;
	public bool jump = false;
	public bool andar = false;
	public GameObject personaje;
	public GameObject explosion;
	public float tiempoespera = 1;
	public GameObject menuDesplegable;
	public float giro = 1;
	public float movement = 1;
	bool voyderecha;
	public float inertia = 20;
	public float reinertia = 20;
	// Use this for initialization
	
	Animator anim;
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		andar = false;
		if (jump){
			andar = false;
		}

		if (GameControl.tocarsuelo && !GameControl.dead){

			if(Input.GetButtonDown("Jump")&& !GameControl.dead){
				jump = true;			
				andar = false;
				//rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y));
				GameControl.tocarsuelo = false;
			}

			anim.SetBool("jump",jump); 
			
			if(Input.GetKey("left") && !jump) {
				rigidbody2D.AddForce(new Vector2(moveForce*-1, 0));
				andar = true;
			}
			anim.SetBool("andar",andar); 
			if(Input.GetKey("right") && !jump) {
				rigidbody2D.AddForce(new Vector2(moveForce, 0));
				andar = true;
			}
			anim.SetBool("andar",andar); 
		} else {
			andar = false;
			if(Input.GetKeyUp("left") && !GameControl.dead) {
				rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x*inertia*-1, 0));
			} else if (Input.GetKey("left")) {
				rigidbody2D.AddForce(new Vector2(reinertia*-1, 0));
			}
			
			if(Input.GetKeyUp("right")) {
				rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x*inertia*-1, 0));
			} else if (Input.GetKey("right")) {
				rigidbody2D.AddForce(new Vector2(reinertia, 0));
			}

		}
	}
	
	void FixedUpdate() {
		if(jump)
		{    
			//rigidbody2D.velocity = v; 
			AudioSource.PlayClipAtPoint(jumpSound, transform.position);
			rigidbody2D.AddForce(new Vector2(rigidbody2D.velocity.x, jumpForce));
			jump = false;

		}



	}
	
	void OnCollisionEnter2D(Collision2D col){
		if(!GameControl.dead && col.gameObject.tag == "Enemy"){
			GameControl.dead = true;
			transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
			GameControl.score = 0;
			this.collider2D.enabled = false;
		}

		if(col.gameObject.tag == "Suelo"){
			GameControl.tocarsuelo = true;
		} 
	}

}