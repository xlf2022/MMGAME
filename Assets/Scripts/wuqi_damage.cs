using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_damage : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float minDamage, maxDamage;
    private float attackDamage;

    public GameObject damageCanvas;//伤害画布

    private Transform player;//主角坐标
    public float Jituinumber;//击退单位值
    public float xiue;//吸血数值
    private PlayerHealth playerHealth1;//调用hp函数,跟吸血相关
    public float jianshu;//减速系数
    public float alldamage;//总伤害数
    public float allxixue;//总吸血数
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerHealth1 = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        alldamage = 0;
        allxixue = 0;
    }


    // Update is called once per frame
    void Update()
    {
 
    }

    //武器检测碰撞,并造成伤害
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("发生了触发器");
        if (other.gameObject.tag == "Enemy")//通过标签触碰检测
        {
            Debug.Log("发生了碰撞");
      
          
                //Debug.Log("We have Hitted");
              
                //造成伤害的函数
                attackDamage = Random.Range(minDamage, maxDamage);
                alldamage += attackDamage;
                other.gameObject.GetComponent<Enemy_follow>().TakenDamage(attackDamage);

                //UI显示画布
                UIdamageShow damageable = Instantiate(damageCanvas, other.transform.position, Quaternion.identity).GetComponent<UIdamageShow>();
                damageable.showUIDamage(Mathf.RoundToInt(attackDamage));//整数类四舍五入

                //武器击退效果=敌人反方向移动，获得角色到敌人的向量然后，让敌人加上那个向量达成击退效果
                Vector2 difference = other.transform.position - player.position;
                difference.Normalize();//单位向量化
                other.transform.position = new Vector2(other.transform.position.x + difference.x*Jituinumber,
                                                       other.transform.position.y + difference.y* Jituinumber);

                //吸血效果
                allxixue += xiue;
                playerHealth1.AddHP(xiue);

                other.gameObject.GetComponent<Enemy_follow>().slowspeed(jianshu);
       

        }
    }

}

