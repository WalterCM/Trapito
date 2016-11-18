﻿using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
 
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

		if(Input.GetKey (KeyCode.W))
		{
			transform.Translate(Vector2.up * speed * Time.deltaTime);
			animator.SetBool("Bool7", true);
			animator.SetBool("Bool6", true);
			animator.SetBool("Bool8", false);
			animator.SetBool("Bool1", false);
			animator.SetBool("Bool2", false);
			animator.SetBool("Bool3", false);
			animator.SetBool("Bool4", false);
			animator.SetBool("Bool5", false);


		}
		//else{
		//	animator.SetBool("Bool", false);
		//}

		if (Input.GetKey (KeyCode.S)) 
		{
			transform.Translate(Vector2.down * speed * Time.deltaTime);
			animator.SetBool("Bool1", true);
			animator.SetBool("Bool2", true);
			animator.SetBool("Bool8", true);
			animator.SetBool("Bool3", false);
			animator.SetBool("Bool4", false);
			animator.SetBool("Bool5", false);
			animator.SetBool("Bool7", false);
			animator.SetBool("Bool6", false);
			/*if (!Input.anyKey){
				animator.SetBool("Bool", false);
			}*/
		}

		if (Input.GetKey (KeyCode.A)){

			transform.Translate(Vector2.left * speed * Time.deltaTime);
			animator.SetBool("Bool4", true);
			animator.SetBool("Bool5", true);	
			animator.SetBool("Bool1", false);
			animator.SetBool("Bool2", false);
			animator.SetBool("Bool3", false);
			animator.SetBool("Bool6", false);
			animator.SetBool("Bool7", true);
			animator.SetBool("Bool8", true);
			/*if (!Input.anyKey){
				animator.SetBool("Bool", false);
			}*/
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			transform.Translate(Vector2.right * speed * Time.deltaTime);
			animator.SetBool("Bool3", true);
			animator.SetBool("Bool6", true);	
			animator.SetBool("Bool1", false);
			animator.SetBool("Bool2", false);
			animator.SetBool("Bool5", false);
			animator.SetBool("Bool4", false);
			animator.SetBool("Bool7", true);
			animator.SetBool("Bool8", true);

			/*if (!Input.anyKey){
				animator.SetBool("Bool", false);
			}*/
		}



    }

    void FixedUpdate()
    {
       // GetComponent<Rigidbody2D>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody2D>().velocity, maxSpeed);
       // GetComponent<Rigidbody2D>().AddForce(v.normalized * moveForce); 

   }
}
