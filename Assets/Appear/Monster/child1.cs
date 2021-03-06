using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class child1 : MonoBehaviour
{
    GameObject hpGage;

    void Start()
    {
        hpGage = GameObject.Find("hpGage");
    }
    /*몬스터 충돌시 체력 감소 (up 트리거 비활성화)*/
    void OnTriggerEnter2D(Collider2D side)
    {
        Debug.Log("피깎임");
        gameObject.transform.parent.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        hpGage.GetComponent<HpGage>().DecreaeHp();
    }
}
