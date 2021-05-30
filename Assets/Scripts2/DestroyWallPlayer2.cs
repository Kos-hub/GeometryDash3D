using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWallPlayer2 : MonoBehaviour
{
    public GameObject wall_1;
    public GameObject player2Trigger_1;
    void OnCollisionEnter(Collision cInfo)
    {
        if(cInfo.collider.tag == "AprilButton")
        {
            Destroy(wall_1);
            Destroy(player2Trigger_1);
        }
    }
}
