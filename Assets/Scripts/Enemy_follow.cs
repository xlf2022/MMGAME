using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_follow : MonoBehaviour
{
    [SerializeField] private float moveSpeed;//移动速度
    private Transform target;//主角的坐标
    [SerializeField] private float maxHp;//最大血量
    public float hp;//当前hp

    [Header("hurt")]
    private SpriteRenderer sp;//获得hurt里的组件，shader
    public float hurtLength;//受伤持续时间
    private float hurtCounter;//受伤计数器


    void Start()
    {
        hp = maxHp;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        if (hurtCounter <= 0)
        { sp.material.SetFloat("_FlashAmount", 0); }
        else
            hurtCounter -= Time.deltaTime;//计数器每帧减少
    }

    private void FollowPlayer()
    {
        //翻转语句
        if(transform.position.x<target.position.x)
            { transform.eulerAngles = new Vector3(0, 180, 0); }
        if (transform.position.x > target.position.x)
        { transform.eulerAngles = new Vector3(0, 0, 0); }

        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        
    }
    //上面是角色跟随和hp设置

    //敌人受到伤害得设置
    public void TakenDamage(float _amout)
    {
        hp -= _amout;
        HurtShader();
        if (hp <= 0)
            Destroy(gameObject);
    }

    private void HurtShader()//控制受到伤害时，材质颜色调整
    {
        sp.material.SetFloat("_FlashAmount", 1);
        hurtCounter = hurtLength;//计数器等于持续时间
    }

}
