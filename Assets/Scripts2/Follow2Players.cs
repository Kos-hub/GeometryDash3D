using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow2Players : MonoBehaviour
{
    public Transform player;
    public Transform player2;

    public bool isPlayer1 = true;
    public Vector3 offset;
    void Update()
    {
        if(isPlayer1 == true)
        {
            transform.position = player.position + offset;

        }else{
            transform.position = player2.position + offset;

        }

    }

    public void playerSwapTo2()
    {
        isPlayer1 = false;
    }

    public void playerSwapTo1()
    {
        isPlayer1 = true;
    }
}
