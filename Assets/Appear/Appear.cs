using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    int time; //프레임 돌아간 횟수를 저장하는 변수 선언
    int appearance = 0;

    public GameObject Obstacle1; //장애물1
    public GameObject Obstacle2; //장애물2
    public GameObject Monster; //몬스터   
    public float y;

    float cloudposy1; //구름1의 y좌표
    float cloudposy2; //구름2의 y좌표

    // Start is called before the first frame update
    void Start()
    {
        time =400; //프레임 측정: time이라는 변수 이용
        y = -2.14f; //몬스터or장애물 출현하는 높이
  
    }

    void Update()
    {

        time++;
        //Debug.Log(time);
        if (time == 500)
        {
            appearance = 0;
            appearance = Random.RandomRange(1, 4);  //장애물(안밀림+밟힘)몬스터 (밟힘)
                                                    // Random.RandomRange(int,int)
            time = 0;
        

            if (appearance == 1)
            {
                GameObject Obs1 = Instantiate(Obstacle1) as GameObject;
                cloudposy1 = Random.Range(0.1f, 4.1f); //구름의 y좌표를 랜덤으로 나오게 하기위해 randomrange를 이용해 변수를 저장.
                // Random.Range(float,float) 
                Obs1.transform.position = new Vector3(10, cloudposy1, 0);
               // Debug.Log(cloudposy1);
            }

           
            if (appearance == 2)
            {
                GameObject Mon = Instantiate(Monster) as GameObject;
                Mon.transform.position = new Vector3(10, -2.45f, 0);
              
            }

            if (appearance == 3)
            {
                GameObject Obs2 = Instantiate(Obstacle2) as GameObject;
                cloudposy1 = Random.Range(-2.1f, 0.1f); //구름2의 y좌표를 랜덤으로 나오게 하기위해 randomrange를 이용해 변수를 저장.
                // Random.Range(float,float) 
                Obs2.transform.position = new Vector3(10, cloudposy2, 0);
          
            }
        }
    }
}