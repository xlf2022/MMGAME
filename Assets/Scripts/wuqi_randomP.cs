using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_randomP : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerP;//玩家位置
    private Vector3 pos;//暂时存储位置的pos
    public float fanwei;//随机的范围正
    public float fufanwei;//随机的范围负
    public void getposition()
    {
        pos.x = playerP.position.x+ Random.Range(fufanwei, fanwei);
        pos.y = playerP.position.y + Random.Range(fufanwei, fanwei);
        pos.z = playerP.position.z;
        // transform.position=
        transform.position = pos;
    }

}
