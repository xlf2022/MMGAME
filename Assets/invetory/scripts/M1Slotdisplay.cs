using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M1Slotdisplay : MonoBehaviour
{
    public item M1slotItem;//道具数据信息
    public Image M1slotimage;//图片
    public Text M1slotinformation;//道具介绍
    public int M1slotNomber;//道具编号
    public int M1kind;//种类

    public string M1slotsinfo;//强转介绍信息

    public string M1slotsinfoC;//中文强转介绍信息

    //新增
    public string M1slotitemName;//道具名称
    public string M1slotitemNameC;//中文名称
  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // M1slotinformation.text = M1slotsinfo;//强转介绍
    }
    
}
