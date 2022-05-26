using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_fanzhuan : MonoBehaviour
{

    public Transform playerFollow;//玩家位置
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerFollow.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerFollow.position + offset;
    }

    void Filp()
    {
       
        if (playerFollow.rotation.y == 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

    }
}
