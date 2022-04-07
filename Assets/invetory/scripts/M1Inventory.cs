using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M1Inventory : MonoBehaviour
{
    public Inventory M1bag;//调用1级背包
    public M1Slotdisplay M1Slotprefabs;//调用预制体格子里的Slotdisplay
    // Start is called before the first frame update
    List<GameObject> itemss = new List<GameObject>();//新建一个itemss临时链表放，放itemss数据
    
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        freshM1bag();
     }
    public void CreatNewItem(item item)//创建一个新物体
    {
        M1Slotdisplay newitem = Instantiate(M1Slotprefabs, M1Slotprefabs.transform.position, Quaternion.identity);
        newitem.gameObject.transform.SetParent(transform);
        newitem.M1slotItem = item;
        newitem.M1slotimage.sprite = item.itemImage;
        newitem.M1slotsinfo = item.itemInfo;
        newitem.M1slotNomber = item.itemNomuber;
        newitem.M1kind = item.itemkind;

        itemss.Add(newitem.gameObject);//把新的物体搞入临时链表
    }

    public void freshM1bag()//刷新1级背包
    {
        clearPool();
        for (int i = 1; i <= M1bag.itemList.Count; i++)
        {
            CreatNewItem(M1bag.itemList[i-1]);
        }

    }

    public void clearPool()//临时清空牌库，用于清空背包
    {
        foreach (var items in itemss)
        {
            Destroy(items);
        }
        itemss.Clear();
    }
}
