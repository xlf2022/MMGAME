using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_jiasu : MonoBehaviour
{
    public PlayerMovement Player;
    public float jiasu;
    public float nowspeed;
    public float zhancunS;
    public GameObject Gamobj;//低级道具
    public GameObject Gamobj1;//低级道具
    // Update is called once per frame
    void Start()
    {
        zhancunS = Player.moveSpeed;
    }
    void Update()
    {
        if (Gamobj != null)
        { Gamobj.SetActive(false); }
        if (Gamobj1 != null)
        { Gamobj1.SetActive(false); }
        nowspeed = zhancunS;
        Player.moveSpeed = nowspeed+jiasu;
    }
}
