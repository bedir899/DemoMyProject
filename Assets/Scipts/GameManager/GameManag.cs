using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManag : MonoBehaviour
{
    public Transform platformGenerator;
    private Vector3 platformStartPoint;
    public Move thePlayer;
    private Vector3 playerStartPoint;
    public Text dead;
    void Start()
    {
        platformStartPoint = platformGenerator.position;
        platformStartPoint = thePlayer.transform.position;

    }
    public void RestartGame()
    {
        StartCoroutine(RestartGameGo());
    }
    public IEnumerator RestartGameGo()
    {
        thePlayer.gameObject.SetActive(false);
        dead.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        thePlayer.gameObject.SetActive(true);
        dead.gameObject.SetActive(false);
    }
    

    

    

    

    

}
