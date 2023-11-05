using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector3 destination;
    float timer = 1f;
    float cd;
    public GameObject enemyPrefab;
    public int id;

    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            GameObject defenseEnemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            defenseEnemy.GetComponent<DefenseEnemy>().SetDestination(destination);
            defenseEnemy.GetComponent<DefenseEnemy>().SetID(id);
            cd = Random.Range(0.99f, 8f);
            timer = cd;
        }
    }
}
