using UnityEngine;
using System.Collections;

public class colider : MonoBehaviour {


	void OnTriggerEnter(Collider other){
		if (other.tag == "col") {
			print ("Choca");
		
		}
	}
}
