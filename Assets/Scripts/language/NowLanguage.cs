using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NowLanguage : MonoBehaviour
{
    public int key;//key值，key=1是中文，key=2是英文
    void Start()
    {
        key = 2;
    }

    public void Chinese()
    {
        key = 1;
    }
    public void English()
    {
        key = 2;
    }
}
