using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dianji : MonoBehaviour
{
    public Animator anmia;//兔兔动画控制
    public music_bofan bofan;
    // Start is called before the first frame update
    public void huifu()
    {
        anmia.SetBool("dianji", false);
        bofan.haixiu_music();
    }
    
}
