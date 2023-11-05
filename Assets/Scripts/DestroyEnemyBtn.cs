using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyBtn : MonoBehaviour
{
    public int id;
    public GameObject closestObj;

    public void DestroyClosestEnemy(int id)
    {
        GameObject[] defenseEnemies = GameObject.FindGameObjectsWithTag("DefenseEnemy");
        float closestDis = 10000f;
        if (defenseEnemies != null)
        {
            foreach (var item in defenseEnemies)
            {
                if (item.GetComponent<DefenseEnemy>().id == id)
                {
                    if (Vector3.Distance(item.transform.position, Vector3.zero) <= closestDis)
                    {
                        closestObj = item;
                        closestDis = Vector3.Distance(item.transform.position, Vector3.zero);
                    }
                }
            }
            if (closestObj != null)
            {
                Destroy(closestObj);
            }
        }
        
    }
}
