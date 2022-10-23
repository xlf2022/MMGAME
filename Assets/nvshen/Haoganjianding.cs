using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.U2D.Animation;

public class Haoganjianding : MonoBehaviour
{
    public Getitem getitem;

    public item thisitem;//判定

    public HaoGan HaoGan;

    public float pingchang;//平常的度数

    public Inventory tutulike;//兔兔喜欢的

    public float add;//加好感的度数

    public Inventory tutuhate;//兔兔讨厌的

    public float jian;//减好感的度数

    public Animator anmia;//兔兔动画控制

    public SpriteResolver LXiong;//左胸配件

    public int LXnumber;//左胸配件数量

    public SpriteResolver RXiong;//右胸配件

    public int RXnumber;//右胸配件数量

    public SpriteResolver Qipao;//旗袍配件

    public int Qipaonumber;//旗袍配件数量

    public SpriteResolver Rhand;//右手配件

    public int Rhandnumber;//右手配件数量

    public SpriteResolver Shangbanshen;//上半身配件

    public int Shangbanshennumber;//上半身配件数量

    public SpriteResolver Shenti;//上半身配件

    public int Shentinumber;//上半身配件数量

    private int allnumber;//装备总数

    public Animator dao;//动画特效刀

    public Animator aixin;//动画爱心

    public music_bofan bofan;//同文件下音源文件

    public void Start()
    {
        allnumber = LXnumber + RXnumber + Qipaonumber + Rhandnumber + Shangbanshennumber + Shentinumber-6;

    }

    public void Update()
    {
        thisitem = getitem.thisitem;
        if (thisitem != null)
        {
            if (tutulike.itemList.Contains(thisitem))//如果该物品包含在喜欢的列表内
            {
                HaoGan.haoganJJ(add);
                thisitem = null;
                getitem.thisitem = null;
                anmia.SetFloat("mean", 0);//切换正常动画
                aixin.speed = 1;//爱心动画播放
                bofan.kaixin_music();//开心音效

            }
            if (tutuhate.itemList.Contains(thisitem))//如果该物品包含在讨厌的列表内
            {
                HaoGan.haoganJJ(jian);
                thisitem = null;
                getitem.thisitem = null;
                anmia.SetFloat("mean", 1);//切换生气动画
                tuoyi();
                dao.speed = 1;//刀动画播放
                int i= Random.Range(0, 5);
                if (i <= 3)
                { bofan.shengqi_music(); }//生气音效
                if (i == 4)
                { bofan.shengqi1_music(); }//生气音效1
            }
        }
       
    }

    public void jiance(SpriteResolver a, int c)
    {
        a.SetCategoryAndLabel(a.GetCategory(),c.ToString());
    }

    public void tuoyi()//设置脱衣系数
    {
        if (allnumber != 0)
        {
            yuandian:
            int random = Random.Range(0,6);
            if (random == 0)
            {
                if (LXnumber == 1)
                { goto yuandian; }
                LXnumber--;
                allnumber--;
            }
            if (random == 1 )
            {
                if (RXnumber == 1)
                { goto yuandian; }
                RXnumber --;
                allnumber--;
            }
            if (random == 2 )
            {
                if (Qipaonumber == 1)
                { goto yuandian; }
                Qipaonumber--;
                allnumber--;
            }
            if (random == 3)
            {
                if (Rhandnumber == 1)
                { goto yuandian; }
                Rhandnumber--;
                allnumber--;
            }
            if (random == 4 )
            {
                if (Shangbanshennumber == 1)
                { goto yuandian; }
                Shangbanshennumber--;
                allnumber--;
            }
            if (random == 5 )
            {
                if (Shentinumber == 1)
                { goto yuandian; }
                Shentinumber--;
                allnumber--;
            }


        }
    }

    public void xianshiyifu()//显示衣服状态
    {
        jiance(LXiong, LXnumber);//检测左胸状态
        jiance(RXiong, RXnumber);
        jiance(Qipao, Qipaonumber);
        jiance(Rhand, Rhandnumber);
        jiance(Shangbanshen, Shangbanshennumber);
        jiance(Shenti, Shentinumber);
    }


}
