using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearInventory : MonoBehaviour
{
    public Inventory MyLV1bag;//1级背包
    
   
    void Start()
    {
        MyLV1bag.itemList.Clear();//游戏开始清空1级背包
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
