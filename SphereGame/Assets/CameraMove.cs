using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform PlayerTransform;


    void Update()
    {
        transform.position = PlayerTransform.position;
    }
}
