using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Creat : MonoBehaviour
{
    public CountDownTest countdown;//导入倒计时文件,满时间文件，内置600秒
    private float time;//临时存放时间，等于最大时间

    public GameObject enemy1;//怪物1
    public float createtime1;//开始刷新时间
    public float freshtime1;//刷新时间

    public GameObject enemy2;//怪物2
    public float createtime2;//开始刷新时间
    public float freshtime2;//刷新时间

    public GameObject enemy3;
    public float createtime3;
    public float freshtime3;

    public GameObject enemy4;
    public float createtime4;
    public float freshtime4;

    public GameObject enemy5;
    public float createtime5;
    public float freshtime5;

    public GameObject enemy6;
    public float createtime6;
    public float freshtime6;

    private bool iscreate1;//判定是否生成
    private Vector2 pos;

    void Start()
    {
        time = countdown.totalTime2;//最大时间存储

    }

    void Update()
    {
        FreshEnemy(createtime1, enemy1,freshtime1);//第一个是开始时间，第二个结束时间，第三个怪物，第四个刷新时间
        FreshEnemy(createtime2, enemy2, freshtime2);
        FreshEnemy(createtime3, enemy3, freshtime3);
        FreshEnemy(createtime4, enemy4, freshtime4);
        FreshEnemy(createtime5, enemy5, freshtime5);
        FreshEnemy(createtime6, enemy6, freshtime6);
    }

    public void FreshEnemy(float Createtime, GameObject Enemy, float Freshtime)
    {
        if (time-countdown.totalTime2 <= Createtime)
        { 
            if (!iscreate1)
                {
                    pos.x = transform.position.x + Random.Range(-2, 2);
                    pos.y = transform.position.y + Random.Range(-2, 2);
                    GameObject.Instantiate(Enemy, pos, Quaternion.identity);
                    iscreate1 = true;
                    StartCoroutine(iscreate(Freshtime));
                }
        }
    }

    IEnumerator iscreate(float time)//每X秒后设定一次
    {
        //Debug.Log("设定了");
        yield return new WaitForSeconds(time);
        iscreate1=false;
    }
}
