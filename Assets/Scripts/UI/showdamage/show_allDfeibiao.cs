using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_allDfeibiao : MonoBehaviour
{
    public GameObject DD;//生成地狱火的游戏物体，挂载地狱火脚本
    public wuqi_diyuhuo linshi;//临时存放脚本
    public Text mytext;
    private int all;
    private int linshis;//临时存放数
    // Start is called before the first frame update
    void Start()
    {
        linshi= DD.GetComponent<wuqi_diyuhuo>();
        linshis = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (linshi.linshi != null)
        {
             all = linshis+Mathf.RoundToInt(linshi.linshi.GetComponent<wuqi_damage>().alldamage*2);
        }
        if (linshi.linshi == null)
        {
            linshis = all;
        }
        
        mytext.text = all.ToString();
    }
}
