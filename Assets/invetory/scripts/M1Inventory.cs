using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M1Inventory : MonoBehaviour
{
    public Inventory M1bag;//调用1级背包数据库
    public M1Slotdisplay M1Slotprefabs;//调用预制体格子里的Slotdisplay
    public itemNO itemNO;//物品编号

    // List<GameObject> itemss = new List<GameObject>();//新建一个itemss临时链表放，放itemss数据
    
    void Start()
    {
        freshM1bag();
    }

    // Update is called once per frame
    void Update()
    {
        


     }
    public void CreatNewItem(item item,int i)//创建一个新物体
    {
       
            M1Slotdisplay newitem = Instantiate(M1Slotprefabs, M1Slotprefabs.transform.position, Quaternion.identity);
            newitem.gameObject.transform.SetParent(transform);
            newitem.M1slotItem = item;
            newitem.M1slotimage.sprite = item.itemImage;
            newitem.M1slotsinfo = item.itemInfo;
            newitem.M1slotNomber = item.itemNomuber;
            newitem.gameObject.GetComponent<itemNO>().itemNomber = i;
        

       // itemss.Add(newitem.gameObject);//把新的物体搞入临时链表
    }

    public void freshM1bag()//刷新1级背包
    {
       // clearPool();
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.childCount == 0) 
                break;
            Destroy(transform.GetChild(i).gameObject);
          
        }
        for (int i = 0; i < M1bag.itemList.Count; i++)
        {
            CreatNewItem(M1bag.itemList[i],i);
        }

    }

    //public void clearPool()//临时清空牌库，用于清空背包
    //{
   //     foreach (var items in itemss)
    //    {
    //        Destroy(items);
    //    }
    //    itemss.Clear();
   // }
}
