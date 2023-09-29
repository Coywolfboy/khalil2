using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Func<Vector3> GetcameraFollowPositionFunc;
    public void Setup(Func<Vector3> GetcameraFollowPositionFunc)
    {
        this.GetcameraFollowPositionFunc = GetcameraFollowPositionFunc;
    }



    // Update is called once per frame
    void Update()
    {
        Vector3 cameraFollowPosition = GetcameraFollowPositionFunc();
        cameraFollowPosition.z = transform.position.z;
        transform.position = cameraFollowPosition;
    }
}
