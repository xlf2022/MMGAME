using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_bofan : MonoBehaviour
{
    public AudioSource shengqi;
    public AudioSource shengqi1;
    public AudioSource haixiu;
    public AudioSource kaixin;
    // Start is called before the first frame update
    public void shengqi_music()
    {
        shengqi.Play();
    }
    public void shengqi1_music()
    {
        shengqi1.Play();
    }
    public void haixiu_music()
    {
        haixiu.Play();
    }
    public void kaixin_music()
    {
        kaixin.Play();
    }
}
