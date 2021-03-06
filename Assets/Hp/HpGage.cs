using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpGage : MonoBehaviour
{
    GameObject hpgage;
    void Start()
    {
        hpgage = GameObject.Find("hpGage");
    }

    public void DecreaeHp() //충돌시 체력 감소 함수
    {
        hpgage.GetComponent<Image>().fillAmount -= 0.2f;
    }
    public void NomDecreaeHp() //기본 체력 감소 함수
    {
        hpgage.GetComponent<Image>().fillAmount -= 0.0001f;
    }
    public void IncreaseHp() //체력 증가 함수
    {
        hpgage.GetComponent<Image>().fillAmount += 0.1f;
    }
    void Update()
    {
        /*체력 0이 될 시, 게임 오버 씬으로 전환*/
        if (hpgage.GetComponent<Image>().fillAmount == 0)
        {
            SceneManager.LoadScene("Ga");
        }
    }
}
    


