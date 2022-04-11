using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemNO : MonoBehaviour
{
    // Start is called before the first frame update
    public int  itemNomber;
    public M1Inventory My1bag;//导入一级背包控制器

    private void Start()
    {
        My1bag = GameObject.Find("Mybag").GetComponent<M1Inventory>();
    }
    public void onclick()//点击时删除对应数据
    {
        My1bag.delectitem(itemNomber);
    }
}
