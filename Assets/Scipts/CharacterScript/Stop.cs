using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    private Move move;
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Stop")
        {
            move.forwardSpeed = 0;
            
            
            
        }
    }
}
