using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class child0: MonoBehaviour

{
  /*몬스터 밟았을 때, 부모 오브젝트가 파괴되는 코드*/
    void OnTriggerEnter2D(Collider2D up)
    {
        Destroy(transform.parent.gameObject);

        Debug.Log("밟");
    }
}