using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLevel : MonoBehaviour
{

    void OnCollisionEnter(Collision cInfo)
    {
        if(cInfo.collider.name == "AprilGround")
        {
            FindObjectOfType<GameManager>().changeLevelName2(); 
        }
    }
}
