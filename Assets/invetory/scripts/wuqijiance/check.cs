using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    // Start is called before the first frame update
    public Inventory M1bag;
    public item thisitem1;//小剑数据
    public item thisitem2;//藤蔓
    public item thisitem3;//水滴武器
    public item thisitem4;//火球武器
    public item thisitem5;//触手武器
    public GameObject myobject1;//小剑1
    public GameObject myobject2;//藤蔓
    public GameObject myobject3;//水滴武器
    public GameObject myobject4;//火球武器
    public GameObject myobject5;//触手武器

    void Start()
    {
        myobject1.SetActive(false);
        myobject2.SetActive(false);
        myobject3.SetActive(false);
        myobject4.SetActive(false);
        myobject5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        checkinbag(thisitem1,myobject1);
        checkinbag(thisitem2, myobject2);
        checkinbag(thisitem3, myobject3);
        checkinbag(thisitem4, myobject4);
        checkinbag(thisitem5, myobject5);
    }
    public void checkinbag(item newitem,GameObject newgameobject)
    {
        if (M1bag.itemList.Contains(newitem) == true)
        {
            //Debug.Log("运行了包含");
            newgameobject.SetActive(true);
        }
        if (M1bag.itemList.Contains(newitem) == false)
        {
            //Debug.Log("运行了不包含");
            newgameobject.SetActive(false);
        }


       // if (M1bag.itemList.Contains(thisitem2) == true)
       // {
       //     //Debug.Log("运行了包含");
      //      myobject2.SetActive(true);
     //   }
      //  if (M1bag.itemList.Contains(thisitem2) == false)
      //  {
      //      //Debug.Log("运行了不包含");
      //      myobject2.SetActive(false);
      //  }
    }
}
