using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public  GameObject zhezhao;//黑色遮罩



    void Start()
    {
        zhezhao.SetActive(false);

    }
    public void Pausegame()
    {
        zhezhao.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resumegame()
    {
        zhezhao.SetActive(false);
        Time.timeScale = 1f;
    }
}
