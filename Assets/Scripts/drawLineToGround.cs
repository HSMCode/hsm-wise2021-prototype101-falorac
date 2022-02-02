using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawLineToGround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        *   The GameObject draws a blue line to the created Ground plane 
        *   for five seconds in scene view.
        */
        float height = transform.position.y;
        Debug.DrawLine(transform.position, transform.position - Vector3.up * height, Color.blue, 5);
    }
}
