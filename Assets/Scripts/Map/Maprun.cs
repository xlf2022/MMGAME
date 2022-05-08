using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maprun : MonoBehaviour
{
    public GameObject mainCam;
    float map_width = 16;
    float total_width;
    int mapNums = 3;//单个方向的的数量
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera");
        total_width = mapNums * map_width;//总宽度
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 floor_position = transform.position;
        if (mainCam.transform.position.x > transform.position.x + total_width / 2)
        {
            floor_position.x += total_width;
            transform.position = floor_position;
        }
        else if (mainCam.transform.position.x < transform.position.x - total_width / 2)
        {
            floor_position.x -= total_width;
            transform.position = floor_position;
        }

        Vector3 floor_Y = transform.position;
        if (mainCam.transform.position.y > transform.position.y + total_width / 2)
        {
            floor_Y.y += total_width;
            transform.position = floor_Y;
        }
        else if (mainCam.transform.position.y < transform.position.y - total_width / 2)
        {
            floor_Y.y -= total_width;
            transform.position = floor_Y;
        }

    }
}
