using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearInventory : MonoBehaviour
{
    public Inventory MyLV1bag;//1级背包数据库
    public M1Inventory M1Inventory;//1级背包处理器
   
    void Start()
    {
        MyLV1bag.itemList.Clear();//游戏开始清空1级背包
        M1Inventory.freshM1bag();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
