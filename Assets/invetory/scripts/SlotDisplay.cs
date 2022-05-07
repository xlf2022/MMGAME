using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotDisplay : MonoBehaviour
{
    public item slotItem;//道具数据信息
    public Image slotimage;//图片
    public Text slotname;//道具名字
    public Text slotinformation;//道具介绍

    public string slotstringname;//强转道具名字
    public string slotsinfo;//强转信息

    //下面是选择按钮，选择以后关闭菜单，和把道具加入到玩家背包数据库
    public GameObject Sybag;//选择道具菜单，商店数据库
    public PauseGame Pgame;//暂停游戏菜单
    public Inventory MyLV1bag;//导入玩家的1级背包库数据库
    private M1Inventory mylv1ga;//导入玩家的1级背包控制器，内含刷新，删除函数。


    public GameObject fullshow1;//道具满了提示
    private GameObject setposition;//道具满了出现位置，以开始设定为主

    public void Start()
    {
        Sybag = GameObject.Find("Bag");
        setposition = GameObject.Find("Canvas");
        mylv1ga= GameObject.Find("Mybag").GetComponent<M1Inventory>();
        Pgame = GameObject.Find("PasueMenu").GetComponent<PauseGame>();
    }
    public void Update()
    {
        slotname.text = slotstringname;
        slotinformation.text = slotsinfo;
    }

    public void onclickbutton()//点击以后把该单元格的数据传输到1级背包库，并关闭选择道具菜单
    {
        Sybag.SetActive(false);
        Pgame.Resumegame();//恢复游戏
        if (MyLV1bag.itemList.Count <= 9)
        { MyLV1bag.itemList.Add(slotItem);
            mylv1ga.freshM1bag();//刷新1级背包显示
        }
        else
        {
            fullshow fullshow22 = Instantiate(fullshow1, setposition.transform.position, Quaternion.identity).GetComponent<fullshow>();
            fullshow22.gameObject.transform.SetParent(setposition.transform);
        }

    }

}
