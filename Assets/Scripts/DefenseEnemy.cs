using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseEnemy : MonoBehaviour
{
    Vector3 dest;
    public float speed;
    public int id;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * (dest - transform.position).normalized);
        if(Vector3.Distance(dest, transform.position) <= 0.1f)
        {
            //health decrease
            Destroy(gameObject);
        }
    }

    public void SetDestination(Vector3 des)
    {
        dest = des;
    }

    public void SetID(int idPara)
    {
        id = idPara;
    }
}
