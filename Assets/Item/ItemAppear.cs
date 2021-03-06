using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAppear : MonoBehaviour 
{
    int i_time;
    public GameObject Star; 
    public GameObject Heart; 
    float random_y;

    int itemapp = 0; 

    
    void Start()
    {
        i_time = 400;
        
    }

    void Update()
    {
        i_time++;
        
        itemapp = Random.RandomRange(1, 4); 
        random_y = Random.Range(0.1f, 3.5f); 
        
        /*아이템 랜덤 출현*/
        
        if (i_time == 700)
        {
            if (itemapp == 1)
            {
                GameObject star = Instantiate(Star) as GameObject;
                Star.transform.position = new Vector3(10, random_y, 0);
                i_time = 0;
            }


            if (itemapp == 2)
            {
                GameObject heart = Instantiate(Heart) as GameObject;
                heart.transform.position = new Vector3(10, random_y, 0);
                i_time = 0;
            }

            if (itemapp == 3)
            {
                GameObject heart = Instantiate(Heart) as GameObject;
                heart.transform.position = new Vector3(10, random_y, 0);
                i_time = 0;
            }


        }
    }
}

