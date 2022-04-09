using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullshow : MonoBehaviour
{
    // Start is called before the first frame update
    public float lifeTimer;//显示持续时间的长短
    public float UpSpeed;//向上移动效果的速度

   // public int Brknumbers;//受伤闪烁的次数
  //  public float Btime;//闪烁的时间

  //  public GameObject my;
  //  private bool myshow;

    void Start()
    {
        Destroy(gameObject, lifeTimer);
     //   myshow = true;
       // StartCoroutine(DoBlink(Brknumbers, Btime));
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(0, UpSpeed * Time.deltaTime, 0);//向上移动
    }

    //IEnumerator DoBlink(int numblink, float seconds)
    //{
   //     for (int i = 0; i < numblink; i++)
    //    {
    //        myshow = !myshow;
    //        my.SetActive(myshow);
    //        yield return new WaitForSeconds(seconds);
     //   }
    //    myshow = true;
   //     my.SetActive(myshow);
   // }
}
