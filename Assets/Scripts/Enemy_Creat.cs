﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Creat : MonoBehaviour
{
    public CountDownTest countdown;//导入倒计时文件,一开始恒定1200,20分钟
    public GameObject enemy1;//怪物1
    public float createtime1;//开始刷新时间
    public float freshtime1;//刷新时间

    public GameObject enemy2;//怪物2
    public float createtime2;//开始刷新时间
    public float freshtime2;//刷新时间


    private bool iscreate1;//判定是否生成
    private Vector2 pos;

    void Start()
    {
        

    }

    void Update()
    {
        FreshEnemy(createtime1, createtime2,enemy1,freshtime1);//第一个是开始时间，第二个结束时间，第三个怪物，第四个刷新时间
        FreshEnemy(createtime2, 0, enemy2, freshtime2);
        // if (countdown.totalTime2>1170 )//倒计时,初始设定为0,奇了怪了40秒才进行下一次
        // {
        //     if (!iscreate1 )
        //     {
        //         pos.x = transform.position.x + Random.Range(-10, 10);
        //         pos.y = transform.position.y + Random.Range(-10, 10);
        //         GameObject.Instantiate(enemy1,pos, Quaternion.identity);
        //         iscreate1 =true;
        //         StartCoroutine(iscreate(freshtime1));
        //     }
        // }
        //  if (countdown.totalTime2 <= 1170)//倒计时,初始设定为0
        //  {
        //      if (!iscreate1)
        //      {
        //          pos.x = transform.position.x + Random.Range(-10, 10);
        //          pos.y = transform.position.y + Random.Range(-10, 10);
        //          GameObject.Instantiate(enemy2, pos, Quaternion.identity);
        //          iscreate1 = true;
        //          StartCoroutine(iscreate(freshtime2));
        //      }
        //  }

    }

    public void FreshEnemy(float Createtime, float Endtime, GameObject Enemy, float Freshtime)
    {
        if (countdown.totalTime2 >= Endtime)
        { if (countdown.totalTime2 <= Createtime)
            if (!iscreate1)
                {
                    pos.x = transform.position.x + Random.Range(-10, 10);
                    pos.y = transform.position.y + Random.Range(-10, 10);
                    GameObject.Instantiate(Enemy, pos, Quaternion.identity);
                    iscreate1 = true;
                    StartCoroutine(iscreate(Freshtime));
                }
        }
    }

    IEnumerator iscreate(float time)//每1秒后设定一次
    {
        //Debug.Log("设定了");
        yield return new WaitForSeconds(time);
        iscreate1=false;
    }
}
