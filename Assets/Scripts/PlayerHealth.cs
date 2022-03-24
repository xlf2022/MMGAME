using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float PmaxHp;//最大血量
    public float Php;//当前hp

    [HideInInspector]
    public bool isattacked;//是否变量做受伤检测
    void Start()
    {
        Php = PmaxHp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakenDamage(float _amout)
    {
        isattacked = true;
        StartCoroutine(isAttackco());//调用下面的 isattackco函数
        Php -= _amout;
        if (Php <= 0)
            Destroy(gameObject);
    }

    IEnumerator isAttackco()//每0.2秒后设定一次
    {
        yield return new WaitForSeconds(0.2f);
        isattacked = false;
    }

}
