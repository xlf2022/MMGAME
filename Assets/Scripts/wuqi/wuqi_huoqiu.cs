using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_huoqiu : MonoBehaviour
{
    public Transform Ppostion;//玩家位置
    public float lifeTimer;//显示持续时间的长短
    public float nowspeed;//速度
    private Transform linshi;//临时存下来位置信息

    void Start()
    {
        Ppostion = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    void Update()
    {

        findgameobject();
        //if (findgameobject() != null)
        // {
        //linshi.position = findgameobject().transform.position;
        //     Vector2 difference = findgameobject().transform.position - Ppostion.position;//目标位置减去玩家位置
        //     float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;//算旋转角度
        //      transform.rotation = Quaternion.Euler(0, 0, rotZ);
        //     transform.position = Vector2.MoveTowards(transform.position, findgameobject().transform.position, nowspeed * Time.deltaTime);
        // }
    }
    public void findgameobject()
    {
        GameObject Close = GameObject.FindGameObjectWithTag("Enemy");
        if (GameObject.FindGameObjectsWithTag("Enemy") != null)
        {
            GameObject[] gos;

            gos = GameObject.FindGameObjectsWithTag("Enemy");

            var distance = Mathf.Infinity;//距离等于正无穷

            var position = Ppostion.position;//玩家的位置

            foreach (GameObject go in gos)
            {

                var diff = (go.transform.position - position); //计算player与Enemy的向量距离差

                var curDistance = diff.sqrMagnitude; //将向量距离平方(防止有负数产生)

                if (curDistance < distance)//找出最近距离
                {
                    Close = go; //更新最近距离敌人
                    distance = curDistance; //更新最近距离
                }
            }
            Vector2 difference = Close.transform.position - Ppostion.position;//目标位置减去玩家位置
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;//算旋转角度
            transform.rotation = Quaternion.Euler(0, 0, rotZ);

            transform.position = Vector2.MoveTowards(transform.position, Close.transform.position, nowspeed * Time.deltaTime);


        }
        else
        {
            Destroy(gameObject);
            
        }
    }
}
