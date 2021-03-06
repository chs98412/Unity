using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
{
    
    void Update()
    {
        /*마우스 좌클릭시, 다시 게임 시작 씬 로드*/
        if (Input.GetMouseButtonDown(0))
        {

            SceneManager.LoadScene("Start");

        }
    }
}
