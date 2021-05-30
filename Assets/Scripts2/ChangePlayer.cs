using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public Follow2Players players; 
    void OnCollisionEnter(Collision cInfo)
    {
        if(cInfo.collider.tag == "Player2Trigger")
        {
            players.playerSwapTo2();
        }
        if(cInfo.collider.tag == "Player1Trigger")
        {
            players.playerSwapTo1();
        }
    }
}
