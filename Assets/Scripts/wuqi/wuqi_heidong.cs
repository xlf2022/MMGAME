using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_heidong : MonoBehaviour
{
    // Start is called before the first frame update
    public float xirushudu;//吸入的速度
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)//主角碰撞检测
    {
        if (other.gameObject.tag == "Enemy")//通过标签触碰检测
        {

            other.transform.position = Vector2.MoveTowards(other.transform.position, transform.position, xirushudu * Time.deltaTime);
        }
    }
}
