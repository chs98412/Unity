using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Star : MonoBehaviour
{

    public float vel; 
    GameObject hpGage;
    GameObject player;
   
    void Start()
    {
        player = GameObject.Find("쿠키짱");

    }
  
    void Update()
    {
        transform.Translate(-vel, 0, 0);
        

    }

    /*피버 아이템 통과시, 피버 모드 */
    void OnTriggerEnter2D(Collider2D star) 
    {
        player.GetComponent<Player>().happystate = 1;
        GetComponent<AudioSource>().Play();

        Debug.Log("피버타임");
    }
}
