using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameIsOver = false;
    public float restartGameDelay = 2f;
    public GameObject winUIElem;


   public void GameOver()
    {
        if(!gameIsOver)
        {
            gameIsOver = true;
            Debug.Log("Game Over");
            Invoke("RestartGame", restartGameDelay);
        }
    }

    void RestartGame()
    {
        string nameOfScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(nameOfScene);
    }

    public void Win()
    {
        //Plays the animation for the level complete thing
        winUIElem.SetActive(true);
    }
}
