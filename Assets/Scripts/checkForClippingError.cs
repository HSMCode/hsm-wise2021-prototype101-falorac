using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkForClippingError : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // GameObject announces the following procedure of checking for clipping
        Debug.LogWarning("We're going to make sure I don't clip into the floor, pal!", this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        *   In this scenario, we assume that every object positioned lower than 1 on the y-axis 
        *   is clipping into the created Ground-Object. If the object is positioned too low, 
        *   a DebugMessageError complains, else a normal DebugMessage tells you everything is fine. 
        */
        if(this.gameObject.transform.position.y < 1) {
            Debug.LogError("Help, I am not positioned correctly! :(", this.gameObject);
        } else {
            Debug.Log("We're good! :)", this.gameObject);
        }
    }
}
