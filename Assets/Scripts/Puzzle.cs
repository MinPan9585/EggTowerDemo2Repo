using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    Vector3 mousePos;
    bool isFollowing = false;
    public Vector3 destination;
    public bool isOnPoint = false; 

    private void OnMouseDown()
    {
        isFollowing = !isFollowing;
        if (!isFollowing)
        {
            //
        }
    }

    private void Update()
    {
        if (isFollowing)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, mousePos.y, 0);
        }
        if (!isFollowing)
        {
            if(Vector3.Distance(transform.position, destination)<= 0.3f)
            {
                isOnPoint = true;
            }
        }
    }
}
