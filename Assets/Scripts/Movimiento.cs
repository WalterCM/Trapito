using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
 
    public float moveForce;
    public float maxSpeed;
    private Vector3 v;

    // Use this for initialization
    void Start () {}

    void Update()
    {
        v = new Vector3(Input.GetAxis("Horizontal"),
                Input.GetAxis("Vertical"), 0.0f);
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.ClampMagnitude(GetComponent<Rigidbody2D>().velocity, maxSpeed);
        GetComponent<Rigidbody2D>().AddForce(v.normalized * moveForce); 
    }
}
