using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour {

    public GameObject objeto;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        objeto.SetActive(true);
        Destroy(gameObject);
        Debug.Log("gg");
            return;
            
    }

    // Use this for initialization
    void Start () {       	
	}
	
	// Update is called once per frame
	void Update () {
	}

    
}
