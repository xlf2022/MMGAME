﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_follow : MonoBehaviour
{
    [SerializeField] private float moveSpeed;//初始设定移动速度
    private float nowspeed;//当前移动速度
    private float Rmixspeed;//随机最小速度
    private float Rmaxspeed;//随机最大速度

    private Transform target;//主角的坐标
    [SerializeField] private float maxHp;//最大血量
    public float hp;//当前hp

    [HideInInspector]
    public bool isattacked;//是否变量做受伤检测

    [Header("hurt")]//用shader做受伤变化
    private SpriteRenderer sp;//获得hurt里的组件，shader
    public float hurtLength;//受伤持续时间
    private float hurtCounter;//受伤计数器

    public GameObject EXPmaker;//经验球生成
    public ClearInventory startset;//开始设置
    public GameObject daoju;//道具掉落


    void Start()
    {
        hp = maxHp;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        startset= GameObject.Find("StartSett").GetComponent<ClearInventory>();
        sp = GetComponent<SpriteRenderer>();

        Rmixspeed = moveSpeed - 0.3f;//随机移动最小速度
        Rmaxspeed = moveSpeed + 0.3f;//随机最大移动速度
        moveSpeed= Random.Range(Rmixspeed, Rmaxspeed);//随机在内移动速度

        nowspeed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        if (hurtCounter <= 0)
        { 
            sp.material.SetFloat("_FlashAmount", 0); 
        }
        else
            hurtCounter -= Time.deltaTime;//计数器每帧减少
    }

    private void FollowPlayer()
    {
        //翻转语句
        if(transform.position.x<target.position.x)
            { transform.eulerAngles = new Vector3(0, 0, 0); }
        if (transform.position.x > target.position.x)
        { transform.eulerAngles = new Vector3(0, 180, 0); }

        transform.position = Vector2.MoveTowards(transform.position, target.position, nowspeed * Time.deltaTime);
        
    }
    //上面是角色跟随和hp设置

    //敌人受到伤害得设置
    public void TakenDamage(float _amout)
    {
        StartCoroutine(isAttackco());//调用下面的 isattackco函数
        hp -= _amout;
        HurtShader();
        if (hp <= 0)
        {
            Instantiate(EXPmaker,transform.position,Quaternion.identity);
            float diaolv= Random.Range(0f,1f);
            if (diaolv < startset.baolv)
            {
                Instantiate(daoju, transform.position, Quaternion.identity);
                startset.diaoluo();
            }
            Destroy(gameObject); 
        }
    }

    private void HurtShader()//控制受到伤害时，材质颜色调整
    {
        sp.material.SetFloat("_FlashAmount", 1);
        hurtCounter = hurtLength;//计数器等于持续时间
    }

    IEnumerator isAttackco()//每0.2秒后设定一次
    {
        yield return new WaitForSeconds(1f);
        nowspeed = moveSpeed;//重新设定移动速度
    }

    public void slowspeed(float slow)
    {
        nowspeed = nowspeed * slow;
    }

}
