using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] public  float HmaxHp;//最大血量
    public  float Hhp;//当前hp

    public PlayerHealth PH;//引用玩家血量参数

    private Image Hbar;//控制图片

    // Start is called before the first frame update
    void Start()
    {
        Hbar = GetComponent<Image>();
        

    }

    // Update is called once per frame
    void Update()
    {
        HmaxHp = PH.PmaxHp;
        Hhp = PH.Php;
        Hbar.fillAmount =Hhp/HmaxHp;
    }
}
