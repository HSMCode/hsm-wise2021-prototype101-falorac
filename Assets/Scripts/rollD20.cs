using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollD20 : MonoBehaviour
{
    // store result
    private int rolledResult;

    // Start is called before the first frame update
    void Start()
    {
        // printing random number from 1 - 20 to console window
        rolledResult = Random.Range(1, 21);
        Debug.Log("Dein Würfel zeigt eine <color=#4caf50>" + rolledResult + "</color>!");
    }

    // Update is called once per frame
    void Update()
    {
        // printing random result to console window when pressing SPACE
        rolledResult = Random.Range(1, 21);
        if (Input.GetKeyDown("space")) {
            Debug.Log("Du hast eine <color=#4caf50>" + rolledResult + "</color> gewürfelt!");
        }
    }
}
