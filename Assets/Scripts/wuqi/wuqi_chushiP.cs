using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wuqi_chushiP : MonoBehaviour
{
    public Transform playerFollow;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        transform.position= playerFollow.position;
        offset = transform.position - playerFollow.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerFollow.position + offset;
    }
}
