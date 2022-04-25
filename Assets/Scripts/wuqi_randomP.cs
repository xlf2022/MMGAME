using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_randomP : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerP;//玩家位置
    private Vector3 pos;//暂时存储位置的pos
    public float X;//正x
    public float fuX;
    public float Y;//正y
    public float fuY;
    public void getposition()
    {
        pos.x = playerP.position.x+ Random.Range(X, fuX);
        pos.y = playerP.position.y + Random.Range(Y, fuY);
        pos.z = playerP.position.z;
        // transform.position=
        transform.position = pos;
    }

}
