using UnityEngine;
using System;

public class Clock : MonoBehaviour {

    public int firstNumber = 6;
    public int secondNumber = 57;
    private float elapsedTime = 0;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        elapsedTime += Time.deltaTime;

        GetComponent<TextMesh>().text = firstNumber.ToString().PadLeft(2, '0') + ":" + secondNumber.ToString().PadLeft(2, '0');

        if (elapsedTime >= 1)
        {
            secondNumber++;
            if (secondNumber == 60)
            {
                secondNumber = 0;
                firstNumber++;
            }
                
            elapsedTime = 0;
        }
	}
}
