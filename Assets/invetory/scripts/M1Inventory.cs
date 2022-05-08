using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M1Inventory : MonoBehaviour
{
    public Inventory M1bag;//调用1级背包数据库，当前背包数据库
    public M1Slotdisplay M1Slotprefabs;//调用预制体格子里的Slotdisplay
    public itemNO itemNO;//物品编号
    public Inventory SY2bag;//调用2级背包数据库
    public Inventory M2bag;//下一级的背包数据库
    // private item newitem;//临时存放升级物体
    private int itemnomber;//临时存放的升级物体编号，作为一个开关，一般情况下为0

    public LvUPslot LVUPitem;//升级以后获得升级的信息

    public M2Inventory M2inventory;//下一级的背包管理器

    // List<GameObject> itemss = new List<GameObject>();//新建一个itemss临时链表放，放itemss数据
    
    void Start()
    {
        freshM1bag();
        itemnomber = 0;
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

    }

    public void freshM1bag()//刷新1级背包
    {
        // clearPool();
        itemnomber = 0;
        for (int i = 0; i < transform.childCount; i++)//删除每次添加的预制体
        {
            if (transform.childCount == 0) 
                break;
            Destroy(transform.GetChild(i).gameObject);
          
        }

        //**************************以下检索3合一升级**************************
        for (int i = 0; i < M1bag.itemList.Count; i++)//判定一下添加以后物件的数量够不够三个，先重置每一itemlist的held=0
        {
            M1bag.itemList[i].itemHeld = 0;
        }
        for (int i = 0; i < M1bag.itemList.Count; i++)//迭代一下，每有一个重复添加一次计数
        {
            if (M1bag.itemList.Contains(M1bag.itemList[i])==true)
            {
                M1bag.itemList[i].itemHeld = M1bag.itemList[i].itemHeld+ 1;
            }
        }
        for (int i = 0; i < M1bag.itemList.Count; i++)//检索有3个就删除物体
        {
            if (M1bag.itemList[i].itemHeld == 3)
            {
                itemnomber = M1bag.itemList[i].itemNextNomber;//临时编号得到下一级的编号
               // newitem = M1bag.itemList[i];//找到赋予的那个item
                M1bag.itemList.Remove(M1bag.itemList[i]);
                i = i - 1;
            }
        }
        //***************************以上检索3合一升级*****************************


        //*********************************************************************//
        //*********************************************************************//


        //***************************以下将临时newitem在SY2找到,并添加进2级背包*******************//
        if (itemnomber != 0)
        {
            for (int i = 0; i < SY2bag.itemList.Count; i++)
            {
                if (SY2bag.itemList[i].itemNomuber == itemnomber)
                {
                    M2bag.itemList.Add(SY2bag.itemList[i]);
                    LVUPitem.getitem(SY2bag.itemList[i]);//显示升级物品，在屏幕下边
                    M2inventory.freshM1bag();
                }
            }

        }
    
        //***************************以下将临时newitem在SY2找到*******************//


       for (int i = 0; i < M1bag.itemList.Count; i++)//检索背包列表，添加回去
        {
            CreatNewItem(M1bag.itemList[i],i);
        }

    }

    public void delectitem(int NO)//删除背包1级里 对应编号的物件
    {
        for (int i = 0; i < M1bag.itemList.Count; i++)
        {
            if (i == NO)
                M1bag.itemList.Remove(M1bag.itemList[i]);
           
            // M1bag.itemList[i].itemObject.SetActive(true);
        }
        freshM1bag();
    }


    

}
