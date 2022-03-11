using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_damage : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float attackDamage;
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
 
    }

    //武器检测碰撞
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("We have Hitted");
            other.gameObject.GetComponent<Enemy_follow>().TakenDamage(attackDamage);



        }
    }

}

