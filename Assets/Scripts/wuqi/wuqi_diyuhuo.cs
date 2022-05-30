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
    void Start()
    {
        // InvokeRepeating("Create", 0, time);
        nowtime = time;
    }

    private void Update()
    {
        nowtime -= Time.deltaTime;
        if (nowtime < 0)
        {
            Instantiate(diyuhuo, playerP.position, Quaternion.identity);
            nowtime = time;
        }
    }

    // public void Create()
    //{
    //   Instantiate(diyuhuo, playerP.position, Quaternion.identity);
    //  }
    // public void Stopped()
    // {
    //     CancelInvoke();
    // }
    // Instantiate(diyuhuo, playerP.position, Quaternion.identity);



}
