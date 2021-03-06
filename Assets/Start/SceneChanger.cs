using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour

{
    void Update()
    {
        /*마우스 좌클릭시, 게임 씬 로드*/
        if (Input.GetMouseButtonDown(0))
        {

            SceneManager.LoadScene("SampleScene");

        }
    }
}
