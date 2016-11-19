using UnityEngine;
using System;

public class Clock : MonoBehaviour {

    public int firstNumber = 6;
    public int secondNumber = 57;
    private float elapsedTime = 0;
    private int elapsedSeconds = 0;
    private string separator = ":";
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        elapsedTime += Time.deltaTime;

        GetComponent<TextMesh>().text = firstNumber.ToString().PadLeft(2, '0') + separator + secondNumber.ToString().PadLeft(2, '0');
        if (elapsedTime >= 1)
        {
            elapsedTime = 0;
            elapsedSeconds++;
        }

        if (elapsedSeconds % 2 == 0)
            separator = ":";
        else
            separator = " ";

        if (elapsedSeconds >= 60)
        {
            secondNumber++;
            if (secondNumber == 60)
            {
                secondNumber = 0;
                firstNumber++;
            }

            if (firstNumber == 24)
            {
                firstNumber = 0;
            }

            elapsedSeconds = 0;
        }
	}
}
