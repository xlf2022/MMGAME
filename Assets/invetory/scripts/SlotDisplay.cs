using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotDisplay : MonoBehaviour
{
    public item slotItem;//数据库
    public Image slotimage;//图片
    public Text slotname;//道具名字
    public Text slotinformation;//道具介绍

    public string slotstringname;//强转道具名字
    public string slotsinfo;//强转信息

    public void Update()
    {
        slotname.text = slotstringname;
        slotinformation.text = slotsinfo;
    }

}
