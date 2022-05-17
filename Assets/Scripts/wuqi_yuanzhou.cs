using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_yuanzhou : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;//玩家位置,圆心位置
    public int banjing;//半径
    public Transform my;//自己的位置

    public float qishi;
    private float TotalTime;


    void Start()
    {
        TotalTime = qishi;
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime += Time.deltaTime;
        var x = banjing * Mathf.Cos(TotalTime);
        var y= banjing * Mathf.Sin(TotalTime);
        my.position = player.position + new Vector3(x,y,0);
    }
}
