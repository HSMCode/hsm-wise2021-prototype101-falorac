using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollD20 : MonoBehaviour
{
    private int rolledResult;

    // Start is called before the first frame update
    void Start()
    {
        // printing random d20 result in console window
        rolledResult = Random.Range(1, 20);
        Debug.Log("Dein Würfel zeigt eine <color=#4caf50>" + rolledResult + "</color>!");
    }

    // Update is called once per frame
    void Update()
    {
        // printing random d20 result in console window when pressing SPACE
        rolledResult = Random.Range(1, 20);
        if (Input.GetKeyDown("space")) {
            Debug.Log("Du hast eine <color=#4caf50>" + rolledResult + "</color> gewürfelt!");
        }
    }
}
