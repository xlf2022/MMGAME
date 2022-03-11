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
        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}
