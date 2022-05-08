using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvUPslot : MonoBehaviour
{
    // Start is called before the first frame update

    public item slotItem;//道具数据信息
    public Image slotimage;//图片
    public Text slotname;//道具名字
    public Text slotinformation;//道具介绍

    public string slotstringname;//强转道具名字
    public string slotsinfo;//强转信息

    public GameObject my;//自己

    void Start()
    {
        my.SetActive(false);//关掉自己
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void getitem(item item)
    {
        my.SetActive(true);//显示自己
        slotItem = item;
        slotimage.sprite = item.itemImage;
        slotstringname = item.itemName;
        slotsinfo = item.itemInfo;
        slotname.text = slotstringname;
        slotinformation.text = slotsinfo;
        StartCoroutine(Noshow());

    }

    IEnumerator Noshow()//每2秒后设定一次
    {
        yield return new WaitForSeconds(4f);
        my.SetActive(false);
    }
}
