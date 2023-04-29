using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject quitGameSelection;
    [ContextMenu("Increase Score")]

        public void addScore(int addScore)
    {
        playerScore = playerScore + addScore;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void quitGame()
    {
       // Debug.Log("Quit Game");
        Application.Quit();
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
