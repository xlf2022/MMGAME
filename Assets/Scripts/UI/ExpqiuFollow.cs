﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpqiuFollow : MonoBehaviour
{
    [SerializeField] private float moveSpeed;//移动速度
    public float fanwei;
    private Transform target;//主角的坐标

    public float EXP;

    public PlayerExp PEXP;

    public AudioSource Mysource;


    void Start()
    {
        PEXP = GameObject.FindGameObjectWithTag("EXP").GetComponent<PlayerExp>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Mysource= GameObject.Find("expget").GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }
    private void FollowPlayer()
    {
       
            //翻转语句
         if (transform.position.x < target.position.x)
        { transform.eulerAngles = new Vector3(0, 180, 0); }
        if (transform.position.x > target.position.x)
        { transform.eulerAngles = new Vector3(0, 0, 0); }
        if (Mathf.Abs(transform.position.x - target.position.x) < fanwei && Mathf.Abs(transform.position.y - target.position.y) < fanwei)
        { transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime); }

    }
    private void OnTriggerEnter2D(Collider2D other)//主角碰撞检测
    {
        if (other.gameObject.tag == "Player")//通过标签触碰检测
        {
            Mysource.Play();
            Destroy(gameObject);
            PEXP.takenExp(EXP);
           
        }
    }
}
