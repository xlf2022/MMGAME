using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_diyuhuo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject diyuhuo;
    public Transform playerP;//玩家位置；
    public float time;//间隔时间
    private float nowtime;//当前的时间
    public GameObject linshi;//临时存放生成的游戏物体
    void Start()
    {
        nowtime = time;
    }

    private void Update()
    {
        nowtime -= Time.deltaTime;
        if (nowtime < 0)
        {
            linshi=Instantiate(diyuhuo, playerP.position, Quaternion.identity);
            nowtime = time;
        }
    }



}
