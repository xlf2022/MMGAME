using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerExp : MonoBehaviour
{
    public float Expmax;//升级最大经验值
    public float Expnow;//当前经验值
    public int LVnumber;//当前等级
    public Text LvText;//升级的文字

    public GameObject Bag;//bag是游戏选择道具界面

    public SYInventory SYinventory;//系统牌库，内含：添加，随机，清空物件函数

    public M1Inventory M1Inventory;//1级背包，内含：添加，刷新函数

    public PauseGame Pgame;//暂停游戏功能

    private Image Expbar;
    // Start is called before the first frame update
    void Start()
    {
        Expbar = GetComponent<Image>();
        Expnow = 0;
        Expmax = 200;
        LVnumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Expbar.fillAmount = Expnow / Expmax;
         

    }

    public void takenExp(float _amout)//获得经验值函数，并检测升级，和检测升级函数
    {
        Expnow = Expnow +_amout;
        if (Expnow >= Expmax)
        {
            Expnow = Expnow- Expmax;
            LVnumber++;
            Expmax += 80;

            //以下是升级选择的部分
            Pgame.Pausegame();//暂停游戏
            Bag.SetActive(true);//升级以后背包显示
            SYinventory.refresh = 3;//重置刷新次数
            SYinventory.clearPool();//清空原来的存储物品,不然刷新就不会删除选择选项
            for (int i = 0; i < SYinventory.refresh; i++)//随机出选项
            {
                SYinventory.CreatNewItem(SYinventory.randomitem());
            }
            


        }
        LvText.text = LVnumber.ToString();
    }

    public void resuemgame()//恢复游戏,关闭背包
    {
        Bag.SetActive(false);
        Pgame.Resumegame();//暂停菜单里的恢复游戏功能
    }
}
