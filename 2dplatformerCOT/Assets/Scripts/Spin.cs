using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Vector3 SpinMagnitude;

    private void Update()
    {
        transform.Rotate(SpinMagnitude * Time.deltaTime);
    }
}
