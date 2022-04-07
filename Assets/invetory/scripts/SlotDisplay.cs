using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotDisplay : MonoBehaviour
{
    public item slotItem;//道具数据信息
    public Image slotimage;//图片
    public Text slotname;//道具名字
    public Text slotinformation;//道具介绍

    public string slotstringname;//强转道具名字
    public string slotsinfo;//强转信息

    //下面是选择按钮，选择以后关闭菜单，和把道具加入到玩家背包数据库
    public GameObject Sybag;//选择道具菜单
    public Inventory MyLV1bag;//导入玩家的1级背包库数据库

    public void Start()
    {
        Sybag = GameObject.Find("Bag");
        
    }
    public void Update()
    {
        slotname.text = slotstringname;
        slotinformation.text = slotsinfo;
    }

    public void onclickbutton()//点击以后把该单元格的数据传输到1级背包库，并关闭选择道具菜单
    {
        Sybag.SetActive(false);
        MyLV1bag.itemList.Add(slotItem);

    }

}
