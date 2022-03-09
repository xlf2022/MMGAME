using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerFollow;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerFollow.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerFollow.position + offset;
        
    }
}
