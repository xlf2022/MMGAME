using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void Start()
    {
        
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
                anmia.SetFloat("mean", 0);
            }
            if (tutuhate.itemList.Contains(thisitem))//如果该物品包含在讨厌的列表内
            {
                HaoGan.haoganJJ(jian);
                thisitem = null;
                getitem.thisitem = null;
                anmia.SetFloat("mean", 1);
            }
            //if (!tutulike.itemList.Contains(thisitem)&& !tutuhate.itemList.Contains(thisitem))
           // { 
          //      HaoGan.haoganJJ(pingchang);
           //     thisitem = null;
          //      getitem.thisitem = null;
           //     anmia.SetFloat("mean", 0);
          //  }
        }
    }
}
