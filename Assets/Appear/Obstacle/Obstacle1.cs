using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1 : MonoBehaviour
{
    public float vel;

    /*장애물 움직임*/
    void Update()
    {
        transform.Translate(-vel, 0, 0);

    }
}
