using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_damage : MonoBehaviour
{
    [SerializeField] private float minDamage, maxDamage;
    private float attackDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)//主角碰撞检测
    {
        if (other.gameObject.tag == "Player")//通过标签触碰检测
        {
            Debug.Log("We have pengzhuang");
            if (other.gameObject.GetComponent<PlayerHealth>().isattacked == false)
            {

                //造成伤害的函数
                attackDamage = Random.Range(minDamage, maxDamage);
                other.gameObject.GetComponent<PlayerHealth>().TakenDamage(attackDamage);


            }

        }
    }
}
