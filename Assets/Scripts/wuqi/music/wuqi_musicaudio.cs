using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_musicaudio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Mysource;
    public string wuqiname;
    void Start()
    {
        Mysource = GameObject.Find(wuqiname).GetComponent<AudioSource>();
        Mysource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
