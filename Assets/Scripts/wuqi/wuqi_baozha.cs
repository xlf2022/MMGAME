using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_baozha : MonoBehaviour
{
    public Animator anim;//动画组件

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("发生了触发器");
        if (other.gameObject.tag == "Enemy")//通过标签触碰检测
        {
            anim.SetFloat("baozha",2);
        }
    }

    public void huifu()
    {
        anim.SetFloat("baozha", 0);
    }
}
