using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    [SerializeField] public float rotateSpeed;

    void Update()
    {
        transform.Rotate(new Vector3(0, rotateSpeed, 0) * Time.deltaTime);
    }
}
