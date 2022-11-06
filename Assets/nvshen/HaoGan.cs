using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HaoGan : MonoBehaviour
{
    public float MAXHaoGan;//最大好感
    public float Haogan;//当前好感
    private Image Hao;//控制图片
    public AudioSource aixin;//爱心音效

    void Start()
    {
        Hao = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Hao.fillAmount = Haogan / MAXHaoGan;
        if (Haogan >= MAXHaoGan)
        {
            Haogan = 50;
            aixin.Play();
        }
    }

    public void haoganJJ(float H)
    {
        Haogan = Haogan + H;
    }
}
