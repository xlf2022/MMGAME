using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_alldamage : MonoBehaviour
{
    public wuqi_damage lv1;
    public wuqi_damage lv2;
    public wuqi_damage lv3;
    public Text mytext;
    private int all;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        all = Mathf.RoundToInt(lv1.alldamage + lv2.alldamage + lv3.alldamage);
        mytext.text = all.ToString();
    }
}
