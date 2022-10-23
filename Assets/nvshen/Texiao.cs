using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texiao : MonoBehaviour
{
    private Animator anim;
    public Haoganjianding haoganjianding;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void sheding()
    {
        haoganjianding.xianshiyifu();
        anim.speed = 0;
    }
}
