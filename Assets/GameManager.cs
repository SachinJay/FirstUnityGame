using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameIsOver = false; 
   public void GameOver()
    {
        if(!gameIsOver)
        {
            gameIsOver = true;
            Debug.Log("Game Over");
        }
    }

    void RestartGame()
    {
        string nameOfScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(nameOfScene);
    }
}
