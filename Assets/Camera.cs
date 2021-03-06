using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Camera : MonoBehaviour
{

    GameObject player;
    GameObject hpgage;

    
    void Start()
    {

        player = GameObject.Find("쿠키짱");
        hpgage = GameObject.Find("hpGage");
    }

    
    void Update()
    {
        /*카메라의 좌표를 플레이어좌표로 설정해서 카메라가 따라가게 함*/ 
        transform.position = new Vector3(transform.position.x, player.transform.position.y + 0.3f, transform.position.z);
        
    }
}
