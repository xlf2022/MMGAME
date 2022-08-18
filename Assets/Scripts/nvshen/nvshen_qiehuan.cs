using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nvshen_qiehuan : MonoBehaviour
{
    public GameObject damageshow;
    public GameObject nvshen;
    public int kaiguan;
    // Start is called before the first frame update
    void Start()
    {
        kaiguan = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            kaiguan = kaiguan + 1;
            if (kaiguan > 3)
            { kaiguan = 1; }
        }
        if (kaiguan == 1)
        {
            nvshen.SetActive(true);
            damageshow.SetActive(false);
        }
        if (kaiguan == 2)
        {
            nvshen.SetActive(false);
            damageshow.SetActive(true);
        }
        if (kaiguan == 3)
        {
            nvshen.SetActive(false);
            damageshow.SetActive(false);
        }

    }
}
