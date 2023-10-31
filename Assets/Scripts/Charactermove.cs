using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactermove: MonoBehaviour
   
{ private Animator Anim;
    public GameObject character;
    void Awake()
    {
        Anim = GetComponent<Animator>();
    }
    void Start()
    {

    }
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            position.x = position.x - 0.05f;
            character.transform.localScale = new Vector3(-1, 1, 0);


        } else if (Input.GetKey(KeyCode.D)) 
        {
            position.x = position.x + 0.05f;
            character.transform.localScale = new Vector3(1, 1, 0);


        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Anim.SetBool("New Bool", true);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Anim.SetBool("New Bool", true);
        }
            if (Input.GetKeyUp(KeyCode.A))
        {
            Anim.SetBool("New Bool", false);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            
            Anim.SetBool("New Bool", false);
        }

        transform.position = position;
    }
}


  


