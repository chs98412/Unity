using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs2_1 : MonoBehaviour
{
    GameObject hpGage;

    void Start()
    {
        hpGage = GameObject.Find("hpGage");
    }

    /*장애물 side 콜라이더 통과시, up 콜라이더 비활성화+ 체력 감소*/
    void OnTriggerEnter2D(Collider2D side)
    {
        Debug.Log("피깎임");
        gameObject.transform.parent.gameObject.GetComponent<BoxCollider2D>().enabled = false; 
        hpGage.GetComponent<HpGage>().DecreaeHp();
    }
}
