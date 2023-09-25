using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    //public float force;
    //float timer = 0f;

    void Update()
    {
        rb.velocity = new Vector3(speed * Time.deltaTime, rb.velocity.y, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
        }
    }
}
