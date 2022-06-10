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
    public item thisitem6;//弓箭武器
    public item thisitem7;//椅子武器
    public item thisitem8;//地狱火武器
    public item thisitem9;//飞镖武器
    public item thisitem10;//戒指武器
    public item thisitem11;//经验种子

    public GameObject myobject1;//小剑1
    public GameObject myobject2;//藤蔓
    public GameObject myobject3;//水滴武器
    public GameObject myobject4;//火球武器
    public GameObject myobject5;//触手武器
    public GameObject myobject6;//弓箭武器
    public GameObject myobject7;//椅子武器
    public GameObject myobject8;//地狱火武器
    public GameObject myobject9;//飞镖武器
    public GameObject myobject10;//戒指武器
    public GameObject myobject11;//经验种子武器

    void Start()
    {
       
        myobject1.SetActive(false);
        myobject2.SetActive(false);
        myobject3.SetActive(false);
        myobject4.SetActive(false);
        myobject5.SetActive(false);
        myobject6.SetActive(false);
        myobject7.SetActive(false);
        myobject8.SetActive(false);
        myobject9.SetActive(false);
        myobject10.SetActive(false);
        myobject11.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        checkinbag(thisitem1,myobject1);
        checkinbag(thisitem2, myobject2);
        checkinbag(thisitem3, myobject3);
        checkinbag(thisitem4, myobject4);
        checkinbag(thisitem5, myobject5);
        checkinbag(thisitem6, myobject6);
        checkinbag(thisitem7, myobject7);
        checkinbag(thisitem8, myobject8);
        checkinbag(thisitem9, myobject9);
        checkinbag(thisitem10, myobject10);
        checkinbag(thisitem11, myobject11);
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
