using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealDianji : MonoBehaviour
{
    public Animator anmia;//兔兔动画控制
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnMouseDown()
    {
        anmia.SetBool("dianji", true);
    }
}
