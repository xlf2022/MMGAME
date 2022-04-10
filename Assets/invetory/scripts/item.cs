using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="New Item",menuName ="Inventory/New Item")]
public class item : ScriptableObject//用于存储所有物体的信息
{
    public string itemName;//名字
    public Sprite itemImage;//对应图片
    public int itemHeld;//持有数
    [TextArea]//增加输入信息的行数
    public string itemInfo;//信息

    public int itemNomuber;//编号
    public GameObject itemObject;//对应的游戏物品
    public int itemNextNomber;//下一级的物品编号
    public int itemkind;//物品对应的种类
    public int itemMax;//系统里最大数
    public int itemInNO;//物品在背包里的系数

}
