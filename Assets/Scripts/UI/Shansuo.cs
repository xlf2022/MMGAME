using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shansuo : MonoBehaviour
{

    public Image myimage;
    public float time ;//维持时间
    public float Notime;//消失时间
    private float nowtime;//临时time
    private float nowNotime;//临时消失时间

    // Start is called before the first frame update
    void Start()
    {
        myimage = GetComponent<Image>();
        nowtime = time;
        nowNotime = Notime;
    }

    // Update is called once per frame
    void Update()
    {
      
            myimage.color = new Color(1f, 0, 0, 0.5f);
            nowtime -= Time.deltaTime;
            if (nowtime < 0)
            {
            
                myimage.color = new Color(1f, 0, 0, 0.2f);
               nowNotime-= Time.deltaTime;
            if (nowNotime < 0)
               { nowtime = time;
                nowNotime = Notime;
                }
            }


    }
}
