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

    public GameObject enemy3;//150
    public float createtime3;
    public float freshtime3;

    public GameObject enemy4;//200
    public float createtime4;
    public float freshtime4;

    public GameObject enemy5;//250
    public float createtime5;
    public float freshtime5;

    public GameObject enemy6;//300
    public float createtime6;
    public float freshtime6;

    public GameObject enemy7;//350
    public float createtime7;
    public float freshtime7;

    public GameObject enemy8;//400
    public float createtime8;
    public float freshtime8;

    public GameObject enemy9;//450
    public float createtime9;
    public float freshtime9;

    public GameObject enemy10;//500
    public float createtime10;
    public float freshtime10;

    public GameObject enemy11;//550
    public float createtime11;
    public float freshtime11;

    public GameObject enemy12;//600
    public float createtime12;
    public float freshtime12;

    public GameObject enemy14;//650
    public float createtime14;
    public float freshtime14;

    public GameObject enemy15;//700
    public float createtime15;
    public float freshtime15;

    public GameObject enemy16;//750
    public float createtime16;
    public float freshtime16;

    public GameObject enemy17;//800
    public float createtime17;
    public float freshtime17;

    public GameObject enemy18;//850
    public float createtime18;
    public float freshtime18;

    public GameObject enemy19;//900
    public float createtime19;
    public float freshtime19;

    public GameObject enemy20;//950
    public float createtime20;
    public float freshtime20;

    public GameObject enemy21;//1000
    public float createtime21;
    public float freshtime21;

    public GameObject enemy22;//1050
    public float createtime22;
    public float freshtime22;

    public GameObject enemy24;//1100
    public float createtime24;
    public float freshtime24;

    public GameObject enemy25;//1200
    public float createtime25;
    public float freshtime25;


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
        FreshEnemy(createtime7, enemy7, freshtime7);
        FreshEnemy(createtime8, enemy8, freshtime8);
        FreshEnemy(createtime9, enemy9, freshtime9);
        FreshEnemy(createtime10, enemy10, freshtime10);
        FreshEnemy(createtime11, enemy11, freshtime11);
        FreshEnemy(createtime12, enemy12, freshtime12);
        FreshEnemy(createtime14, enemy14, freshtime14);
        FreshEnemy(createtime15, enemy15, freshtime15);
        FreshEnemy(createtime16, enemy16, freshtime16);
        FreshEnemy(createtime17, enemy17, freshtime17);
        FreshEnemy(createtime18, enemy18, freshtime18);
        FreshEnemy(createtime19, enemy19, freshtime19);
        FreshEnemy(createtime20, enemy20, freshtime20);
        FreshEnemy(createtime21, enemy21, freshtime21);
        FreshEnemy(createtime22, enemy22, freshtime22);
        FreshEnemy(createtime24, enemy24, freshtime24);
        FreshEnemy(createtime25, enemy25, freshtime25);

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
