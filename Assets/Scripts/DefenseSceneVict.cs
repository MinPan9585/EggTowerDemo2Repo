using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefenseSceneVict : MonoBehaviour
{
    public float timer = 60f;
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}
