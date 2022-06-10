using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_jiyangshu : MonoBehaviour
{
    public float EXP;//经验值

    public PlayerExp PEXP;//玩家经验

    public void ExpUp()
    {
        PEXP.takenExp(EXP);
    }

}
