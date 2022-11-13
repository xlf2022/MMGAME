using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SYInventory : MonoBehaviour
{
    public Inventory SYinventory;//调用牌库
    public SlotDisplay Slotprefabs;//调用预制体格子里的Slotdisplay
    public int refresh = 3;//刷新次数

    List<GameObject> itemss = new List<GameObject>();//新建一个临时链表
    void Start()
    {

        // for (int i = 0; i < refresh; i++)
        //{
        //     CreatNewItem(randomitem());
        //}
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

    public void CreatNewItem(item item)//创建一个新物体
    {
        SlotDisplay newitem = Instantiate(Slotprefabs, Slotprefabs.transform.position, Quaternion.identity);
        newitem.gameObject.transform.SetParent(transform);
        newitem.slotItem = item;
        newitem.slotimage.sprite = item.itemImage;
        newitem.slotstringname = item.itemName;
        newitem.slotsinfo = item.itemInfo;
        newitem.slotstringnameC = item.itemNameC;
        newitem.slotsinfoC = item.itemInfoC;

        itemss.Add(newitem.gameObject);//把新的物体搞入临时链表
    }


    public void clearPool()//临时清空牌库，用于清空背包选择
    {
        foreach (var items in itemss)
        {
            Destroy(items);
        }
        itemss.Clear();
    }

}
