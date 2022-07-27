using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daoju : MonoBehaviour
{
    // Start is called before the first frame update
    public item thisitem;//该物品的信息
    public SpriteRenderer image;//显示物品图片
    public Inventory sy1bag;//系统1级牌库。
    public M1Inventory my1bagcontrol;//自己的1级背包控制器
    public Inventory MyLV1bag;//1级背包库
    public GameObject fullshow1;//道具满了提示
    private GameObject setposition;//道具满了出现位置，以开始设定为主
    public AudioSource Mysource;

    void Start()
    {
        thisitem= sy1bag.itemList[Random.Range(0, sy1bag.itemList.Count)];
        image.sprite = thisitem.itemImage;
        my1bagcontrol = GameObject.Find("Mybag").GetComponent<M1Inventory>();
        setposition = GameObject.Find("fullshowweizhi");
        Mysource = GameObject.Find("itemget").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)//主角碰撞检测
    {
        if (other.gameObject.tag == "Player")//通过标签触碰检测
        {
            if (MyLV1bag.itemList.Count <= 9)
            {
                Mysource.Play();
                MyLV1bag.itemList.Add(thisitem);
                my1bagcontrol.freshM1bag();//刷新1级背包显示

                Destroy(gameObject);
            }
            else
            {
                fullshow fullshow22 = Instantiate(fullshow1, setposition.transform.position, Quaternion.identity).GetComponent<fullshow>();
                fullshow22.gameObject.transform.SetParent(setposition.transform);
            }
        }
    }
}
