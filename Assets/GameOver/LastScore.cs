using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScore : MonoBehaviour 
{

    GameObject Lastscore;
    int Wlsscore;
    void Start()
    {
        Lastscore = GameObject.Find("Score");
        Wlsscore = Lastscore.GetComponent<Score2>().score2;
    }
    /*게임 오버 후 최종 점수 출력*/
    void Update()
    {
        GetComponent<Text>().text = ("당신의 점수는~? "+Wlsscore);
    }
}
