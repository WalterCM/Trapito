using UnityEngine;
using System.Collections;

public class Noquiero : MonoBehaviour {
    void onTriggerEnter2D(Collider2D other)
    {
        print("collides");
    }
}
