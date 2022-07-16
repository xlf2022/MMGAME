using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_pengzhuangpohuai : MonoBehaviour
{
    public float lifeTimer;//显示持续时间的长短
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Enemy")//通过标签触碰检测
        { Destroy(gameObject, lifeTimer); }
     }
}
