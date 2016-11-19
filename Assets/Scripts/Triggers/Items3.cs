using UnityEngine;
using System.Collections;

public class Items3 : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        Destroy(gameObject);
        Debug.Log("gg");
        return;

    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }


}
