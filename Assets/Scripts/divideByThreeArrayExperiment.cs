using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class divideByThreeArrayExperiment : MonoBehaviour
{
    // Variables for calculation
    public float[] numbers = new float[5];
    private float calculatedResult;
    
    // Variables for console print with default or descriptive text
    public string consoleMessage = "Das Objekt hat folgendes Ergebnis errechnet:";
    private string declaredVariables = "Übergebene Werte: ";

    // Start is called before the first frame update
    void Start()
    {
        // declared numbers are added and divided by three
        for (int i = 0; i < numbers.Length; i++) {
            calculatedResult += numbers[i];
        }
        calculatedResult = calculatedResult / 3;

        // assembling declared numbers for console output
        for (int i = 0; i < numbers.Length; i++) {
            // checking for last number (no semicolon necessary)
            if (i < numbers.Length - 1) {
                declaredVariables += numbers[i] + ", ";
            } else {
                declaredVariables += numbers[i];
            }
        }

        // console prints custom result message and number inputs
        Debug.Log(consoleMessage + " <b><color=#00bcd4>" + calculatedResult + "</color></b> \n" + 
        declaredVariables, this.gameObject);
    }
}
