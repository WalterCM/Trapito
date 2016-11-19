using UnityEngine;
using System.Collections;

public class Detecter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(GameObject.Find("lana4") != null)
        {
            GameObject.FindWithTag("aguja").SetActive(true);
        }
	
	}
}
