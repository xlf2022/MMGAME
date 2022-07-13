using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resumegame : MonoBehaviour
{
    // Start is called before the first frame update
    public PauseGame Pgame;//暂停游戏功能
    public GameObject Ggame;//要关闭的物体
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void resuemgame()//恢复游戏,关闭背包
    {
        Ggame.SetActive(false);
        Pgame.Resumegame();//暂停菜单里的恢复游戏功能
    }
}
