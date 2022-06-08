using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearInventory : MonoBehaviour
{
    public Inventory MyLV1bag;//1级背包数据库
    public M1Inventory M1Inventory;//1级背包处理器
    public Inventory MyLV2bag;//2级背包数据库
    public Inventory MyLV3bag;//3级背包数据库

    public Inventory SY1bag;//1级牌库
    public item thisitem1;//小剑数据
    public item thisitem2;//藤蔓
    public item thisitem3;//水滴武器
    public item thisitem4;//火球武器
    public item thisitem5;//触手武器
    public item thisitem6;//弓箭武器
    public item thisitem7;//椅子武器
    public item thisitem8;//鲜花武器
    public item thisitem9;//地狱火武器
    public item thisitem10;//飞镖武器

    public item sword1;


    void Start()
    {
        SY1bag.itemList.Clear();//清空1级牌库
        for (int i = 0; i < 12; i++)
        {
            SY1bag.itemList.Add(thisitem1);
            SY1bag.itemList.Add(thisitem2);
            SY1bag.itemList.Add(thisitem3);
            SY1bag.itemList.Add(thisitem4);
            SY1bag.itemList.Add(thisitem5);
            SY1bag.itemList.Add(thisitem6);
            SY1bag.itemList.Add(thisitem7);
            SY1bag.itemList.Add(thisitem8);
            SY1bag.itemList.Add(thisitem9);
            SY1bag.itemList.Add(thisitem10);
        }




        MyLV1bag.itemList.Clear();//游戏开始清空1级背包
        MyLV2bag.itemList.Clear();
        MyLV3bag.itemList.Clear();

        MyLV1bag.itemList.Add(sword1);

        M1Inventory.freshM1bag();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
