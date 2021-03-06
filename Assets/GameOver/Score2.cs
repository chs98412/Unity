using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score2 : MonoBehaviour
{
    public int score2;
    GameObject player;

   void Awake ()
    {
        /*씬 전환시에도 오브젝트 보존*/
        DontDestroyOnLoad(gameObject); 

    }
    void Start()
    {
        player = GameObject.Find("쿠키짱");   
    }

    void Update()
    {
       score2= player.GetComponent<Player>().score;
    }
}
