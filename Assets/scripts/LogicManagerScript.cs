using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicManagerScript : MonoBehaviour
{
   public int playScore;
   public Text score;
   public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
   public void addScore(int scoreToAdd)
   {
        playScore += scoreToAdd;
        score.text = playScore.ToString();
   }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void toggleGameOver() 
    {
        gameOverScreen.SetActive(true);
    }
}
