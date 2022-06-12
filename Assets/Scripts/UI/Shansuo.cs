using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shansuo : MonoBehaviour
{

    public GameObject show;
    public Inventory mylv1bag;

    // Start is called before the first frame update
    void Start()
    {
        show.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mylv1bag.itemList.Count == 10)
        { show.SetActive(true); }
        else
        { show.SetActive(false); }

    }

}
