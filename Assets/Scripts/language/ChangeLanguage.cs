using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguage : MonoBehaviour
{
    public NowLanguage Nowlanguage;
    public Text thistext;
    public string Chinese;
    public string English;

    void Start()
    {
        thistext = GetComponent<Text>();
        Nowlanguage = GameObject.FindGameObjectWithTag("Language").GetComponent<NowLanguage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Nowlanguage.key == 1)
        {
            thistext.text = Chinese;
        }
        if (Nowlanguage.key == 2)
        { 
            thistext.text = English;
        }
    }
}
