using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIdamageShow : MonoBehaviour
{
    public Text damageText;
    public float lifeTimer;//显示持续时间的长短
    public float UpSpeed;//向上移动效果的速度

    private void Start()
    {
        Destroy(gameObject, lifeTimer);
    }
    private void Update()
    {
        transform.position += new Vector3(0, UpSpeed * Time.deltaTime, 0);//向上移动
    }

    public void showUIDamage(float _amout)
    {
        damageText.text = _amout.ToString();
    }
}
