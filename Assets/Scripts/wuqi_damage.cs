using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_damage : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float attackDamage;
    private Transform player;//主角坐标
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    // Update is called once per frame
    void Update()
    {
 
    }

    //武器检测碰撞,并造成伤害
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (other.gameObject.GetComponent<Enemy_follow>().isattacked == false)
            {
                Debug.Log("We have Hitted");
                other.gameObject.GetComponent<Enemy_follow>().TakenDamage(attackDamage);

                //武器击退效果=敌人反方向移动，获得角色到敌人的向量然后，让敌人加上那个向量达成击退效果
                Vector2 difference = other.transform.position - player.position;
                other.transform.position = new Vector2(other.transform.position.x + difference.x / 6,
                                                       other.transform.position.y + difference.y / 6);
            }

        }
    }

}

