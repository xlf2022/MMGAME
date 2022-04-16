using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M3Inventory : MonoBehaviour
{
    public Inventory M1bag;//调用1级背包数据库，当前背包数据库
    public M1Slotdisplay M1Slotprefabs;//调用预制体格子里的Slotdisplay
    public itemNO itemNO;//物品编号
    // public Inventory SY2bag;//调用2级背包数据库
    //public Inventory M2bag;//下一级的背包数据库
    // private item newitem;//临时存放升级物体
    private int itemnomber;//临时存放的升级物体编号，作为一个开关，一般情况下为0

    // public M1Inventory M2inventory;//下一级的背包管理器


    void Start()
    {
        freshM1bag();
        itemnomber = 0;
    }

    // Update is called once per frame
    void Update()
    {



    }
    public void CreatNewItem(item item, int i)//创建一个新物体
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
        for (int i = 0; i < transform.childCount; i++)//删除每次添加的预制体
        {
            if (transform.childCount == 0)
                break;
            Destroy(transform.GetChild(i).gameObject);

        }

        for (int i = 0; i < M1bag.itemList.Count; i++)//检索背包列表，添加回去
        {
            CreatNewItem(M1bag.itemList[i], i);
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
