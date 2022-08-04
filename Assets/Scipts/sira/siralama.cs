using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class siralama : MonoBehaviour
{
    public Transform[] players;
    public Text sira;


    void Start()
    {
        
         
    }

    // Update is called once per frame
    void Update()
    {
        List<float> list = new List<float>();
        list.Add(players[0].position.x);
        list.Add(players[1].position.x);
        list.Add(players[2].position.x);
        list.Add(players[3].position.x);
        list.Add(players[4].position.x);
        list.Add(players[5].position.x);
        list.Add(players[6].position.x);
        list.Add(players[7].position.x);
        list.Add(players[8].position.x);
        list.Add(players[9].position.x);
        list.Sort();
        list.Reverse();
        int sir = list.IndexOf(players[0].position.x) + 1;
        


        sira.text = sir + " / 10";

        
    }
}
