using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFight : MonoBehaviour
{
    public GameManager gameManager;
   void OnCollisionEnter()
   {
       gameManager.BossName();
   }
}
