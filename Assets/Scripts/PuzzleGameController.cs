using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            Debug.Log("win");
        }
        else
        {
            arrayNumber = 0;
        }
    }
}
