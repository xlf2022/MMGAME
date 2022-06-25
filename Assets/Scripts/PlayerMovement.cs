using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;

    [SerializeField] public float moveSpeed;
    private float nowSpeed;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        nowSpeed = moveSpeed;
    }


    private void Update()
    {
        StartCoroutine(isAttackco());
        moveH = Input.GetAxis("Horizontal") * nowSpeed;

          moveV = Input.GetAxis("Vertical") * nowSpeed;
        Flip();

    }

   private void FixedUpdate()
    {
        //rb.velocity = new Vector2(moveH, moveV);
        transform.position += Vector3.right * moveH*Time.deltaTime;
        transform.position += Vector3.up * moveV * Time.deltaTime;
    }

    private void Flip()
    {
        if (moveH > 0) transform.eulerAngles = new Vector3(0, 0, 0);
        if (moveH < 0) transform.eulerAngles = new Vector3(0, 180, 0);
    }

    IEnumerator isAttackco()//每1秒后设定一次
    {
        yield return new WaitForSeconds(1f);
        nowSpeed = moveSpeed;//重新设定移动速度
    }
}

