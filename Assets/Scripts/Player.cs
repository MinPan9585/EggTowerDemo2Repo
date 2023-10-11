using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float force;
    float timer = 0f;

    void Update()
    {
        rb.velocity = new Vector3(speed * Time.deltaTime, rb.velocity.y, 0);

        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            rb.AddForce(new Vector3(0, force, 0));
        }

        timer += Time.deltaTime;
        //if(timer >= 4.5f)
        //{
        //    speed *= 1.2f;
        //    timer = 0;
        //}
    }
}
