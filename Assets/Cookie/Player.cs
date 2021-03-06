using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics; 
using debug = UnityEngine.Debug; 
using UnityEngine.UI; 

public class Player : MonoBehaviour
{
    Rigidbody2D rigid; 
    public float jumpForce; 
    float state; 


    GameObject myscore;
    Stopwatch sw1 = new Stopwatch(); 
    Stopwatch sw2 = new Stopwatch();
    public int happystate;
    float t1;
    public float t2;
    public int score;
    GameObject hpGage;
    
   

    void Awake() 
    {
        score = 0; 
        t1 = 0;
        t2 = 0;
    }
    
    void Start() 
    {
        myscore = GameObject.Find("Text"); 
        sw1.Start(); 

        rigid = GetComponent<Rigidbody2D>(); 
        state = 0;
        
        myscore = GameObject.Find("Text"); 
        
        hpGage = GameObject.Find("hpGage");
    }

    void Update()
    {

        debug.Log(happystate);


        /*점프 or 슬라이딩 코드 : 스페이스바 or 아래화살표  입력에 따라 플레이어 움직임 */

        if (rigid.velocity.y==0) 
        {
            state = 0;   
        }
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rigid.AddForce(transform.up * jumpForce);
            state++; 
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Rotate(0, 0, 90);
        }
        if (transform.position.y < -10)
            SceneManager.LoadScene("SampleScene");

        
        /*점수 코드*/

        t1 = sw1.ElapsedMilliseconds;

        if (t1 % 300 == 0) 
            score += 10; 

        myscore.GetComponent<Text>().text = ("SCORE : " + score); 

        /*피버 모드*/
        if (happystate == 1)
        {
           
            while (transform.position.y < 17)
                transform.Translate(0, 0.05f, 0); //피버모드로 올라감

            happystate = 2;
        }
        if (happystate == 2)
        {
            sw2.Start(); 
            t2 = sw2.ElapsedMilliseconds;
           
            if (t2 > 10000) 
            {
                happystate = 3;
                sw2.Reset();
            }
        }
        if (happystate == 3)
        {
            while (transform.position.y > 6.49f)
                transform.Translate(0, -0.05f, 0);
            happystate = 0;
        }
        hpGage.GetComponent<HpGage>().NomDecreaeHp();
    }
}
