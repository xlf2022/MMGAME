using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_P : MonoBehaviour
{
    public float lifeTimer;//显示持续时间的长短
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
