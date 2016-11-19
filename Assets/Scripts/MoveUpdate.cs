using UnityEngine;
using System.Collections;

public class MoveUpdate : MonoBehaviour {

	//public float moveForce;
	//public float maxSpeed;
	public float speed;
	private Rigidbody2D rb;
	private Vector3 v;
	Animator animator;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();

	}


	void Update()
	{
		// v = new Vector3(Input.GetAxis("Horizontal"),
		//         Input.GetAxis("Vertical"), 0.0f);

		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector2.up * speed * Time.deltaTime);
			animator.SetBool ("Arriba", true);
			animator.SetBool ("Derecha", false);
			animator.SetBool ("Abajo", false);
			animator.SetBool ("Izquierda", false);
			animator.SetBool ("Bool7", true);
			animator.SetBool ("Bool6", true);
			animator.SetBool ("Bool9", true);
			animator.SetBool ("Bool11",true);
			animator.SetBool ("Bool8", false);
			animator.SetBool ("Bool1", false);
			animator.SetBool ("Bool2", false);
			animator.SetBool ("Bool3", false);
			animator.SetBool ("Bool4", false);
			animator.SetBool ("Bool5", false);
			animator.SetBool ("Bool10",false);
			animator.SetBool ("Bool12", false);
			animator.SetBool ("Idle", false);
		}
		else if (!Input.anyKey) {
			animator.SetBool ("Idle", true);

		}


		if (Input.GetKey (KeyCode.S)) 
		{
			transform.Translate(Vector2.down * speed * Time.deltaTime);
			animator.SetBool ("Abajo", true);
			animator.SetBool ("Derecha", false);
			animator.SetBool ("Arriba", false);
			animator.SetBool ("Izquierda", false);
			animator.SetBool("Bool1", true);
			animator.SetBool("Bool2", true);
			animator.SetBool("Bool8", true);
			animator.SetBool("Bool3", false);
			animator.SetBool("Bool4", false);
			animator.SetBool("Bool5", false);
			animator.SetBool("Bool7", false);
			animator.SetBool("Bool6", false);
			animator.SetBool("Idle", false);
		}
		else if (!Input.anyKey){
			animator.SetBool ("Idle", true);

		}

		if (Input.GetKey (KeyCode.A)){

			transform.Translate(Vector2.left * speed * Time.deltaTime);
			animator.SetBool ("Izquierda", true);
			animator.SetBool ("Derecha", false);
			animator.SetBool ("Arriba", false);
			animator.SetBool ("Abajo", false);
			animator.SetBool("Bool4", false);
			animator.SetBool("Bool5", true);	
			animator.SetBool("Bool1", false);
			animator.SetBool("Bool2", false);
			animator.SetBool("Bool3", false);
			animator.SetBool("Bool6", false);
			animator.SetBool("Bool7", true);
			animator.SetBool ("Bool8", false);
			animator.SetBool ("Bool9", false);
			animator.SetBool ("Bool10", true);
			animator.SetBool("Idle", false);
		}
		else if (!Input.anyKey){
			animator.SetBool ("Idle", true);

		}

		if (Input.GetKey (KeyCode.D)) 
		{
			transform.Translate(Vector2.right * speed * Time.deltaTime);
			animator.SetBool ("Derecha", true);
			animator.SetBool ("Arriba", false);
			animator.SetBool ("Abajo", false);
			animator.SetBool ("Izquierda", false);
			animator.SetBool("Bool3", false);
			animator.SetBool("Bool6", true);	
			animator.SetBool("Bool1", false);
			animator.SetBool("Bool2", false);
			animator.SetBool("Bool5", false);
			animator.SetBool("Bool4", false);
			animator.SetBool("Bool7", true);
			animator.SetBool("Bool8", false);
			animator.SetBool("Bool11", false);
			animator.SetBool ("Bool12", true);
			animator.SetBool("Idle", false);
		}

		else if (!Input.anyKey){
			animator.SetBool ("Idle", true);
		}



	}

	void FixedUpdate()
	{
		// GetComponent<Rigidbody2D>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody2D>().velocity, maxSpeed);
		// GetComponent<Rigidbody2D>().AddForce(v.normalized * moveForce); 

	}
}
