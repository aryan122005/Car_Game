using System;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player ;
    private Vector3 offset = new Vector3(0, 6, -13);

    private static Vector3 Vector3(int v1, int v2, int v3)
    {
        throw new NotImplementedException();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //wrinting this code to camera follow the car
        transform.position = player.transform.position + offset;
        
    }
}
