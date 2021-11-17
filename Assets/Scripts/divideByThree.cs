using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class divideByThree : MonoBehaviour
{
    // Variables for calculation
    public float firstNumber;
    public float secondNumber;
    public float thirdNumber;
    public float fourthNumber;
    public float fifthNumber;
    private float calculatedResult;

    // Variable for console print with default
    public string consoleMessage = "Das Objekt hat folgendes Ergebnis errechnet:";

    // Start is called before the first frame update
    void Start()
    {
        // Declared numbers are added and divided by three
        calculatedResult = (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber) / 3;

        // Console prints custom result message and number inputs
        Debug.Log(consoleMessage + " <b><color=#00bcd4>" + calculatedResult + "</color></b> \n" + 
        "Übergebene Werte: " + firstNumber + ", " + secondNumber + ", " + thirdNumber + ", " + fourthNumber + ", " + fifthNumber, this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
