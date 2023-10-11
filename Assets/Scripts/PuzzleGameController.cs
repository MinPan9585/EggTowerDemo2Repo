using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleGameController : MonoBehaviour
{
    public Puzzle[] puzzles;
    public int arrayNumber = 0;

    void Update()
    {
        for (int i = 0; i < puzzles.Length; i++)
        {
            if (puzzles[i].isOnPoint)
            {
                arrayNumber++;
            }
        }

        //Debug.Log(puzzles.Length);
        if(arrayNumber == puzzles.Length)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            arrayNumber = 0;
        }
    }
}
