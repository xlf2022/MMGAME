using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    // Start is called before the first frame update
    public item thisitem;
    public Inventory M1bag;
    public GameObject myobject;
    void Start()
    {
        myobject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (M1bag.itemList.Contains(thisitem) == true)
        {
            Debug.Log("运行了包含");
            myobject.SetActive(true); 
        }
        if (M1bag.itemList.Contains(thisitem) == false)
        {
            Debug.Log("运行了不包含");
            myobject.SetActive(false); }
    }
}
