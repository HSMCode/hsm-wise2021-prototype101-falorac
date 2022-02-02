using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveNameAndPosition : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // GameObject the script is attached to says its "name" aka the name you gave it within the hierarchy
        Debug.Log("Hello, my name is " + this.gameObject + "!", this.gameObject);

        // GameObject the script is attached to states x, y, z coordinates
        Debug.Log(this.gameObject + " is positioned at " + this.gameObject.transform.position, this.gameObject);
    }
}
