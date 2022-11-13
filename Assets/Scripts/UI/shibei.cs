using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shibei : MonoBehaviour
{
    public NowLanguage Nowlanguage;
    public string writename;//笔者名字
    public string writenameC;//笔者中文名字
    [TextArea]//增加输入信息的行数
    public string itemInfo;//信息
    public string itemInfoC;//中文信息


    private GameObject startset;//开始设置，调用引导石碑
    private Text shibeiinfo;//石碑信息
    
    private Text shibeiW;//石碑写者
    private bool yidu;//已读信息
    private PauseGame Pgame;//暂停游戏功能

    void Start()
    {
        Nowlanguage = GameObject.FindGameObjectWithTag("Language").GetComponent<NowLanguage>();
        yidu = false;//非读状态
        Destroy(gameObject, 20);
        Pgame = GameObject.Find("PasueMenu").GetComponent<PauseGame>();
        startset = GameObject.Find("StartSett");
        //shibeiinfo = GameObject.Find("shibeiinfo").GetComponent<Text>();
        //shibeiW = GameObject.Find("writename").GetComponent<Text>();
        //startset.GetComponent<ClearInventory>().shibeiinfo.text= itemInfo;
        //startset.GetComponent<ClearInventory>().shibeiW.text = writename;
        //shibeiinfo.text = itemInfo;
        //shibeiW.text = writename;
    }

    // Update is called once per frame
    void Update()
    {
        if (Nowlanguage.key == 2)
        {
            startset.GetComponent<ClearInventory>().shibeiinfo.text = itemInfo;
            startset.GetComponent<ClearInventory>().shibeiW.text = writename;
        }
        if (Nowlanguage.key == 1)
        {
            startset.GetComponent<ClearInventory>().shibeiinfo.text = itemInfoC;
            startset.GetComponent<ClearInventory>().shibeiW.text = writenameC;
        }

    }
    private void OnTriggerEnter2D(Collider2D other)//主角碰撞检测
    {
        if (other.gameObject.tag == "Player")//通过标签触碰检测
        {
            if (yidu == false)
            {
                Pgame.Pausegame();//暂停游戏
                ClearInventory start = startset.GetComponent<ClearInventory>();
                start.shibei.SetActive(true);
                yidu = true;
            }

        }
    }
}
