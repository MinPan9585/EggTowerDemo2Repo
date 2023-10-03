using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermove: MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("a"))
        {
            position.x = position.x - 0.05f;
        } else if (Input.GetKey("d")) 
        {
            position.x = position.x + 0.05f;
        }

        transform.position = position;
    }
}


  


