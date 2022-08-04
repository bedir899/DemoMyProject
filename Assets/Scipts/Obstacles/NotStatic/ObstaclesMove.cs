using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMove : MonoBehaviour
{
    [SerializeField] public float rotateSpeed;
    private Vector3 newLocation = new Vector3(8.924f, 0.101f, 0.557f);
    private Vector3 an;

    private Vector3 startPosition;
    void Start()
    {
        an = transform.position;
    }
    void Update()
    {
       /* transform.position = Vector3.Lerp(transform.position, newLocation, Time.deltaTime);
        if (transform.position==newLocation)
        {
            transform.position = Vector3.Lerp(newLocation, transform.position, Time.deltaTime);
        }*/
        
        
        transform.Rotate(new Vector3(0, rotateSpeed,0) * Time.deltaTime);
        
    }
    
}
