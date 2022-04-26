using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory M1bag;
    public item thisitem1;//小剑数据
    public item thisitem2;//藤蔓
    public GameObject myobject1;//小剑1
    public GameObject myobject2;//藤蔓
    void Start()
    {
        myobject1.SetActive(false);
        myobject2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        checkinbag();
    }
    public void checkinbag()
    {
        if (M1bag.itemList.Contains(thisitem1) == true)
        {
            //Debug.Log("运行了包含");
            myobject1.SetActive(true);
        }
        if (M1bag.itemList.Contains(thisitem1) == false)
        {
            //Debug.Log("运行了不包含");
            myobject1.SetActive(false);
        }


        if (M1bag.itemList.Contains(thisitem2) == true)
        {
            //Debug.Log("运行了包含");
            myobject2.SetActive(true);
        }
        if (M1bag.itemList.Contains(thisitem2) == false)
        {
            //Debug.Log("运行了不包含");
            myobject2.SetActive(false);
        }
    }
}
