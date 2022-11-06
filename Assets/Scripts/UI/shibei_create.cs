using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shibei_create : MonoBehaviour
{
    public CountDownTest countdown;//导入倒计时文件,满时间文件，内置600秒
    private float time;//临时存放时间，等于最大时间

    public GameObject shibei1;//石碑1
    public float createtime1;//出现时间
    public GameObject shibei2;//石碑2
    public float createtime2;//出现时间
    public GameObject shibei3;//石碑3
    public float createtime3;//出现时间
    public GameObject shibei4;//石碑4
    public float createtime4;//出现时间
    public GameObject shibei5;//石碑5
    public float createtime5;//出现时间

    public AudioSource Mysource;//石碑音效

    private bool iscreate1;

    // Start is called before the first frame update
    void Start()
    {
        time = countdown.totalTime2;//最大时间存储
        iscreate1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        createshibei(createtime1,shibei1,1);
        createshibei(createtime2, shibei2, 1);
        createshibei(createtime3, shibei3, 1);
        createshibei(createtime4, shibei4, 1);
        createshibei(createtime5, shibei5, 1);

    }

    public void createshibei(float Createtime, GameObject Enemy, float Freshtime)
    {
        if (!iscreate1)
        {
            if (time - countdown.totalTime2 == Createtime)
            {
                GameObject.Instantiate(Enemy, transform.position, Quaternion.identity);
                iscreate1 = true;
                StartCoroutine(iscreate(Freshtime));
                Mysource.Play();
            }
        }
    }
    IEnumerator iscreate(float time)//每X秒后设定一次
    {
        //Debug.Log("设定了");
        yield return new WaitForSeconds(time);
        iscreate1 = false;
    }
}
