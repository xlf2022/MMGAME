using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shibei : MonoBehaviour
{
    public string writename;//笔者名字
    [TextArea]//增加输入信息的行数
    public string itemInfo;//信息
    private GameObject yindao;//引导石碑
    private Text shibeiinfo;//石碑信息
    private Text shibeiW;//石碑写者

    void Start()
    {
        yindao= GameObject.Find("yindao");
        shibeiinfo= GameObject.Find("shibeiinfo").GetComponent<Text>();
        shibeiW= GameObject.Find("writename").GetComponent<Text>();
        shibeiinfo.text = itemInfo;
        shibeiW.text = writename;
        yindao.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)//主角碰撞检测
    {
        if (other.gameObject.tag == "Player")//通过标签触碰检测
        {
            yindao.SetActive(true);

        }
    }
}
