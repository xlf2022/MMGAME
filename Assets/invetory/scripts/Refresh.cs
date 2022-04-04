using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refresh : MonoBehaviour
{
    public SYInventory SYinventory;

    public void onclickrefresh()
    {
        SYinventory.clearPool();
        if (SYinventory.refresh >= 2)
        {
            SYinventory.refresh = SYinventory.refresh - 1;
            for (int i = 0; i < SYinventory.refresh; i++)//随机出物品
            {
                SYinventory.CreatNewItem(SYinventory.randomitem());
            }
        }
    }
}
