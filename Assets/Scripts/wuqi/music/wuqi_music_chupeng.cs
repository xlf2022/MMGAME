using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_music_chupeng : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Mysource;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")//通过标签触碰检测
        {
            Mysource.Play();
        }
    }
}
