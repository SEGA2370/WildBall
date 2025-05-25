using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotation : MonoBehaviour
{
    Vector3 rotation = Vector3.zero;

    private readonly float degpersec = 10;

    void Update()
    {
        rotation.x = degpersec * Time.deltaTime;
        transform.Rotate(rotation, Space.World);
    }
}
