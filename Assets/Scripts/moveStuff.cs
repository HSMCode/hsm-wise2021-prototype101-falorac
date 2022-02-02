using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveStuff : MonoBehaviour
{
    public float speed = 1;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.Space)) {
            transform.Translate(Vector3.right * 2 * Time.deltaTime * speed);
        }
    }
}
