using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs2_0 : MonoBehaviour
{
    /*up 콜라이더 충돌시(밟을 때), side 콜라이더 비활성화 */
    void OnCollisionEnter2D(Collision2D up)
    {
        gameObject.transform.GetChild(0).gameObject.GetComponent<BoxCollider2D>().enabled = false;

    }
}
