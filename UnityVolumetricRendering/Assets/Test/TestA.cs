using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class TestA : MonoBehaviour
{
    [ColorUsage(true, true)]
    public Color color;

    public Vector3 right;
    public Vector3 forward;
    public Vector3 up;

    void Update()
    {
        right = transform.right;
        forward = transform.forward;
        up = transform.up;
    }
}
