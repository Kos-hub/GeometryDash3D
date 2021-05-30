using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDestroyed : MonoBehaviour
{
        void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Player")
        {
            Destroy(gameObject);
            FindObjectOfType<GameManager>().deleteBossName();
            FindObjectOfType<GameManager>().activeSecondName();
        }
    }
}
