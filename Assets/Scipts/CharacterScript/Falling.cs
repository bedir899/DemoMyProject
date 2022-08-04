using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Falling : MonoBehaviour
{
  

    public GameManag theGameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {

            theGameManager.RestartGame();
        }
    }
   
}
