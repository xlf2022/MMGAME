using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTest : MonoBehaviour
{
    private float totalTime1 = 300;
    public float totalTime2 ;
    private float intervalTime = 1;

    public Text CountDown1Text;
    public Text CountDown2Text;
    // Start is called before the first frame update
    void Start()
    {
       // CountDown1Text.text = string.Format(
        //    "{0:D2}:{1:D2}",(int)totalTime1/60, (int)totalTime1%60);
        CountDown2Text.text = string.Format(
            "{0:D2}:{1:D2}", (int)totalTime2 / 60, (int)totalTime2 % 60);
        //StartCoroutine(CountDown1());
    }

    // Update is called once per frame
    void Update()
    {
        if (totalTime2 > 0)
        {
            intervalTime -= Time.deltaTime;
            if (intervalTime <= 0)
            {
                intervalTime += 1;
                totalTime2--;
                CountDown2Text.text = string.Format(
                "{0:D2}:{1:D2}", (int)totalTime2 / 60, (int)totalTime2 % 60);

            }
        }
    }
}
