using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float PmaxHp;//最大血量
    public float Php;//当前hp
    public int Brknumbers;//受伤闪烁的次数
    public float Btime;//闪烁的时间
    private Renderer myRender;

    [HideInInspector]
    public bool isattacked;//是否变量做受伤检测
    void Start()
    {

        Php = PmaxHp;

        myRender = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakenDamage(float _amout)//收到伤害函数
    {
        isattacked = true;
        StartCoroutine(isAttackco());//调用下面的 isattackco函数
        Php -= _amout;
        if (Php <= 0)
        { Destroy(gameObject); }
        BlinkPlayer(Brknumbers, Btime);
    }



    IEnumerator isAttackco()//每0.2秒后设定一次,无敌帧检测时间，这段时间收到伤害不会再受伤
    {
        yield return new WaitForSeconds(0.15f);
        isattacked = false;
    }

    void BlinkPlayer(int numblink, float seconds)//受伤闪烁函数
    {
        StartCoroutine(DoBlink(numblink, seconds));
    }

    IEnumerator DoBlink(int numblink, float seconds)
    {
        for (int i = 0; i < numblink; i++)
        {
            myRender.enabled = !myRender.enabled;
            yield return new WaitForSeconds(seconds);
        }
        myRender.enabled = true;
    }

    public void AddHP(float _amout1)//加血函数
        {
        if (Php < PmaxHp)
            Php = Php +_amout1;
        }
}
