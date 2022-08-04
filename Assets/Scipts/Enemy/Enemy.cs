using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform location;
    void Start()
    {
        NavMeshAgent nMesh = GetComponent<NavMeshAgent>();
        nMesh.destination = location.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
