
using UnityEngine;

public class LevelChange : MonoBehaviour
{
    public GameManager gameManager;
    void OnCollisionEnter()
    {
        gameManager.CompleteLevel();    
    }

}
