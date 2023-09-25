using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundspawn : MonoBehaviour
{
    public GameObject ground;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(ground, transform.position + new Vector3(20, 0, 0), Quaternion.identity);
    }
}
