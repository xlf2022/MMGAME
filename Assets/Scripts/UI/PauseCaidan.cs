using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseCaidan : MonoBehaviour
{
    public GameObject caidan;
    public PauseGame Pgame;
    public AudioMixer audio1;
    public Slider BgmSlider;
    public Slider YinxiaoSlider;
    public Slider PeiyinSlider;

    private void Start()
    {
        caidan.SetActive(false);
    }

    public void OpenCaidan()
    {
        Pgame.Pausegame();
        caidan.SetActive(true);
    }

    public void OffCaidan()
    {
        Pgame.Resumegame();
        caidan.SetActive(false);
    }
    public void setbgm()//背景音乐
    {
        audio1.SetFloat("Bgm", BgmSlider.value);
    }
    public void setyinxiao()//音效音乐
    {
        audio1.SetFloat("YinXiao", YinxiaoSlider.value);
    }
    public void setpeiyin()//配音音乐
    {
        audio1.SetFloat("PeiYin", PeiyinSlider.value);
    }


}
