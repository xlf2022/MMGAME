using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_allXfeibiao : MonoBehaviour
{
    public wuqi_diyuhuo linshi1;//1级飞镖
    public wuqi_diyuhuo linshi2;//
    public wuqi_diyuhuo linshi3;//
    public Text mytext;
    private int a1;//统计1级的飞镖
    private int a2;//统计2级的飞镖
    private int a3;//统计3级的飞镖
    private int all;
    private int linshis;//临时存放数
    private int linshis2;
    private int linshis3;
    // Start is called before the first frame update
    void Start()
    {
        linshis = 0;
        a1 = 0;
        a2 = 0;
        a3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (linshi1.linshi != null)
        {
            a1 = linshis + Mathf.RoundToInt(linshi1.linshi.GetComponent<wuqi_damage>().allxixue * 2);
        }
        if (linshi1.linshi == null)
        {
            linshis = a1;
        }

        if (linshi2.linshi != null)
        {
            a2 = linshis2 + Mathf.RoundToInt(linshi2.linshi.GetComponent<wuqi_damage>().allxixue * 2);
        }
        if (linshi2.linshi == null)
        {
            linshis2 = a2;
        }

        if (linshi3.linshi != null)
        {
            a3 = linshis3 + Mathf.RoundToInt(linshi3.linshi.GetComponent<wuqi_damage>().allxixue * 2);
        }
        if (linshi3.linshi == null)
        {
            linshis3 = a3;
        }

        all = a1 + a2 + a3;
        mytext.text = all.ToString();
    }
}
