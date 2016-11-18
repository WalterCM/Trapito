using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	private Rigidbody rb;
	public float speed;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>(); 
	
	}
	
	// Update is called once per frame
	void Update () {
	

		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb.velocity = movement * speed;

	}
}
