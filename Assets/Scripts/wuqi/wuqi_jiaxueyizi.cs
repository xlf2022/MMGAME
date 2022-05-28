using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_jiaxueyizi : MonoBehaviour
{
    public float addxue;//加血数值
    public float shijian;//静止多少秒开始加血
    private int kaiguan;//加血开关
    private float moveH, moveV;//移动参数
    public GameObject texiao;//椅子特效

    public PlayerHealth PlayerHealth;//调用加血函数
    // Start is called before the first frame update
    void Start()
    {
        kaiguan = 0;
        texiao.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        if (moveV != 0 || moveH != 0)//或语句
        {
               kaiguan = 1;
            texiao.SetActive(false);
            StartCoroutine(isAttackco());
        }
        else
        {
            if (kaiguan == 0)
            { PlayerHealth.AddHP(addxue);
                Debug.Log("正在加血");
                texiao.SetActive(true);
            }
        }

    }

    IEnumerator isAttackco()//每XX秒后设定一次,让开关=0
    {
        yield return new WaitForSeconds(shijian);
        kaiguan = 0;
    }
}
