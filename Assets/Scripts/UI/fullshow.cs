using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullshow : MonoBehaviour
{
    // Start is called before the first frame update
    public float lifeTimer;//显示持续时间的长短
    public float UpSpeed;//向上移动效果的速度
    void Start()
    {
        Destroy(gameObject, lifeTimer);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, UpSpeed * Time.deltaTime, 0);//向上移动
    }
}
