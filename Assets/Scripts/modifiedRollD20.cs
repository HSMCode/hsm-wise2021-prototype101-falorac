using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modifiedRollD20 : MonoBehaviour
{
    // choose lucky numbers
    private int[] luckyNumbers = {3, 9, 13};
    // output variables 
    private string tellLuckyNumbers;
    private int rolledResult;
    private bool amILucky;

    // Start is called before the first frame update
    void Start()
    {
        // print lucky number array and tell player to press SPACE (roll die)
        for (int i = 0; i < luckyNumbers.Length; i++) {
            if(i < luckyNumbers.Length - 1) {
                tellLuckyNumbers += luckyNumbers[i] + ", ";
            } 
            else {
                tellLuckyNumbers += " und " + luckyNumbers[i];
            }
        }
        Debug.Log("Deine Glückszahlen sind <b>" + tellLuckyNumbers + "</b>! \n" +
        "Würfle nun mit Leertaste!");
    }

    // Update is called once per frame
    void Update()
    {
        // generate random number between 1 - 20
        rolledResult = Random.Range(1, 20);

        // check if rolled number is equal to any lucky number and change boolean
        for (int i = 0; i < luckyNumbers.Length; i++) {
            if (rolledResult == luckyNumbers[i]) {
                amILucky = true;
                break;
            } else {
                amILucky = false;
            }
        }

        // console output if player was lucky (result = a lucky number)
        if (Input.GetKeyDown("space")) {
            if (amILucky) {
                Debug.Log("<color=#4caf50>Du hast eine " + rolledResult + " gewürfelt und gewonnen :)</color>");
            } else {
                Debug.Log("<color=#f34a5e>Du hast eine " + rolledResult + " gewürfelt und verloren :(</color>");
            }
        }
    }
}
