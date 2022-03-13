using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_follow : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private Transform target;
    [SerializeField] private float maxHp;
    public float hp;

    void Start()
    {
        hp = maxHp;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
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
        if (hp <= 0)
            Destroy(gameObject);
    }

}
