using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dianji : MonoBehaviour
{
    public Animator anmia;//兔兔动画控制
    // Start is called before the first frame update
    public void huifu()
    {
        anmia.SetBool("dianji", false);
    }
    
}
