using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jelly : MonoBehaviour
{
    public float vel;
    GameObject player;
   
    void Start()
    {
        player = GameObject.Find("쿠키짱"); 

    }

    /*10초간 피버 타임*/
    void Update()
    {
        transform.Translate(-vel, 0, 0); 

        if (player.GetComponent<Player>().t2 > 10000) 
            Destroy(gameObject);
    }
    /*젤리 통과시, 추가 점수*/
    void OnTriggerEnter2D(Collider2D jelly) 
    {
        player.GetComponent<Player>().score += 50; 
        Destroy(gameObject); 
    }
}

