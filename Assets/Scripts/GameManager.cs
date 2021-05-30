using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
bool gameHasEnded = false;
public GameObject completeLevelUI;
public GameObject gameOverUI;
public GameObject BossUI;

public GameObject LevelName_2; 

public GameObject secondPlayerName;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        secondPlayerName.SetActive(false);
    }

    public void activeSecondName()
    {
        secondPlayerName.SetActive(true);
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void deleteBossName()
    {
        Destroy(BossUI);
    }

    public void BossName()
    {
        BossUI.SetActive(true);
    }
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;

            Invoke("Restart", 1f);
        }
    }

    public void changeLevelName2()
    {
        LevelName_2.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

