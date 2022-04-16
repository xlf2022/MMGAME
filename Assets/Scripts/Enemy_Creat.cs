using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Creat : MonoBehaviour
{
    public CountDownTest countdown;//导入倒计时文件,一开始恒定1200,20分钟
    public GameObject enemy1;//怪物1
    private bool iscreate1;//判定是否生成
    private Vector2 pos;

    void Start()
    {
        

    }

    void Update()
    {
        
        if (countdown.totalTime2>0 )//倒计时,初始设定为0
        {
            if (!iscreate1 )
            {
                pos.x = transform.position.x + Random.Range(-10, 10);
                pos.y = transform.position.y + Random.Range(-10, 10);
                GameObject.Instantiate(enemy1,pos, Quaternion.identity);
               iscreate1 =true;
                StartCoroutine(iscreate());
            }
        }
        
    }

    IEnumerator iscreate()//每1秒后设定一次
    {
        //Debug.Log("设定了");
        yield return new WaitForSeconds(0.5f);
        iscreate1=false;
    }
}
