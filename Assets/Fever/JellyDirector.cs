using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyDirector : MonoBehaviour
{
    public GameObject jelly;
    float jelly_y;
    int jelly_t;
    GameObject state;
    int feverstate;

    void Start()
    {
        jelly_t = 0;
      
    }
    void Update()
    {
        jelly_y = Random.RandomRange(17.0f, 25.1f);
        jelly_t++;
      
        /*젤리를 자동으로 생성*/
            if (jelly_t == 30)
            {

                Debug.Log("젤리");
                GameObject jellydir = Instantiate(jelly) as GameObject;
                jellydir.transform.position = new Vector3(10, jelly_y, 0);
                jelly_t = 0;
            }
        }
    }

