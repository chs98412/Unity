using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart_real : MonoBehaviour
{
    public float vel; 
    GameObject hpGage;

    
    void Start()
    {
        hpGage = GameObject.Find("hpGage");
    }

    void Update()
    {
        transform.Translate(-vel, 0, 0);
    }

    /*체력 충전 아이템 통과시, 체력 증가*/
    void OnTriggerEnter2D(Collider2D heart) 
    {
        Destroy(gameObject);
        hpGage.GetComponent<HpGage>().IncreaseHp(); 
        Debug.Log("체력충전");
    }
}
