using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_allDfeibiao : MonoBehaviour
{
    public wuqi_diyuhuo linshi1;//1级飞镖
    public float number1;
    public wuqi_diyuhuo linshi2;//
    public float number2;
    public wuqi_diyuhuo linshi3;//
    public float number3;
    public Text mytext;
    private int a1;//统计1级的飞镖
    private int a2;//统计2级的飞镖
    private int a3;//统计3级的飞镖
    private int all;
    // Start is called before the first frame update
    void Start()
    {
        a1 = 0;
        a2 = 0;
        a3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
  
        a1 = Mathf.RoundToInt(linshi1.alldamage* number1);
        a2= Mathf.RoundToInt(linshi2.alldamage * number2);
        a3 = Mathf.RoundToInt(linshi3.alldamage * number3);


        all = a1 + a2 + a3;
        mytext.text = all.ToString();
    }
}
