using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_yuqun : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;//移动速度
    public float juli;//移动距离
    public int x;//x方向
    public float huisu;//回收速度
    public float Flytime;//飞行时间
    private float NFlytime;//当前飞行时间

    public Transform PlayP;//玩家位置
    private Rigidbody2D r2d;//自己的rigbod组件
    private Transform myP;//自己的位置
    private float office;//当前位置Y的差距记录
    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        r2d.velocity = new Vector2(x * speed, 0);
        myP = GetComponent<Transform>();
        PlayP = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        NFlytime = Flytime;
        transform.position = new Vector3(PlayP.position.x, PlayP.position.y + transform.position.y, 0);
        office = PlayP.position.y - transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        r2d.transform.position = new Vector3(transform.position.x, PlayP.position.y-office, 0);
        if (r2d.velocity.x ==0)
        {
            if (transform.position.x < PlayP.position.x)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                r2d.velocity = new Vector2(-x * speed, 0);
            }
            if (transform.position.x > PlayP.position.x)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                r2d.velocity = new Vector2(x * speed, 0);
            }
        }


        if (Mathf.Abs(myP.transform.position.x - PlayP.position.x) >=juli)
        {

            if (transform.position.x < PlayP.position.x)
            { transform.eulerAngles = new Vector3(0, 180, 0);
                r2d.velocity = new Vector2(-x * speed, 0);
            }
            if (transform.position.x > PlayP.position.x)
            { transform.eulerAngles = new Vector3(0, 0, 0);
                r2d.velocity = new Vector2(x * speed, 0);
            }
        }

    }

}
