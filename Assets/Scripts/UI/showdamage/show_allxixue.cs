using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_allxixue : MonoBehaviour
{
    public wuqi_damage lv1;
    public float number1;
    public wuqi_damage lv2;
    public float number2;
    public wuqi_damage lv3;
    public float number3;
    public Text mytext;
    private int all;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        all = Mathf.RoundToInt(lv1.allxixue* number1 + lv2.allxixue* number2 + lv3.allxixue* number3);
        mytext.text = all.ToString();
    }
}
