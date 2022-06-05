using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_zizhuan : MonoBehaviour
{
    public float speed;//移动速度
    public float zizhuanS;//自转速度
    public int x;//x方向
    public int y;//y方向
    public float huisu;//回收速度
    public float Flytime;//飞行时间
    private float NFlytime;//当前飞行时间
    public float Ptime;//停留时间
    private float NPtime;//当前停留时间

    public Transform PlayP;//玩家位置
    private Rigidbody2D r2d;//自己的rigbod组件
    private Transform myP;//自己的位置
    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
        r2d.velocity = new Vector2(x * speed, y * speed);
        myP = GetComponent<Transform>();
        PlayP = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        NFlytime = Flytime;
        NPtime = Ptime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, zizhuanS);//自转
        NFlytime -= Time.deltaTime;
        if (NFlytime < 0)
        {
            r2d.velocity = new Vector2(0, 0);
            NPtime-= Time.deltaTime;
            if (NPtime < 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, PlayP.position, huisu * Time.deltaTime);
                if (Mathf.Abs(myP.transform.position.x - PlayP.position.x) < 0.8f && Mathf.Abs(myP.transform.position.y - PlayP.position.y) < 0.8f)
                {
                    Destroy(gameObject);
                }
            }
        }

    }


}
