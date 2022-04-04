using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SYInventory : MonoBehaviour
{
    public Inventory SYinventory;//调用牌库
    public SlotDisplay Slotprefabs;//调用预制体格子里的Slotdisplay
    public int refresh = 3;//刷新次数

    void Start()
    {

        for (int i = 0; i < refresh; i++)
        {
            CreatNewItem(randomitem());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public item randomitem()//随机返回一个值
    {
        item Ritem = SYinventory.itemList[Random.Range(0, SYinventory.itemList.Count)];//牌库里随机一个物件数据
        return Ritem;
    }

    public  void CreatNewItem(item item)//创建一个新物体
    {
        SlotDisplay newitem = Instantiate(Slotprefabs, Slotprefabs.transform.position, Quaternion.identity);
        newitem.gameObject.transform.SetParent(transform);
        newitem.slotItem = item;
        newitem.slotimage.sprite = item.itemImage;
        newitem.slotstringname = item.itemName;
        newitem.slotsinfo = item.itemInfo;
    }

}
