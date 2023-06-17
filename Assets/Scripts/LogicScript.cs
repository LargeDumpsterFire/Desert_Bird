/*
 Make highscore saver top three scores 
make a player selection screen customize or choose which bird you want to choose
imlement a token system to by upgrades or new birds 
make a shop to buy new birds or upgrades
options to adjust sound and music
 add view highschore button to end game screen
 
 
 
 
 */
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
