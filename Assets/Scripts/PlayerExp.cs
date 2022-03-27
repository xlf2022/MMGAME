using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerExp : MonoBehaviour
{
    public float Expmax;//升级最大经验值
    public float Expnow;//当前经验值
    public int LVnumber;//当前等级
    public Text LvText;

    private Image Expbar;
    // Start is called before the first frame update
    void Start()
    {
        Expbar = GetComponent<Image>();
        Expnow = 0;
        Expmax = 150;
        LVnumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Expbar.fillAmount = Expnow / Expmax;
         

    }

    public void takenExp(float _amout)//获得经验值函数
    {
        Expnow = Expnow +_amout;
        if (Expnow >= Expmax)
        {
            Expnow = Expnow- Expmax;
            LVnumber++;
            Expmax += 80;
        }
        LvText.text = LVnumber.ToString();
    }
}
