using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int score1;
    public int score2;
    public Text score1Text;
    public Text score2Text;
    LeftPaddle player1;
    LeftPaddle player2;
    BallMovement ball;
    public GameObject resetPanel;

    private void Start()
    {
        player1 = GameObject.Find("LeftPaddle").GetComponent<LeftPaddle>();
        player2 = GameObject.Find("RightPaddle").GetComponent<LeftPaddle>();
        ball = GameObject.Find("Ball").GetComponent<BallMovement>();
    }

    public void Score1Calculator(int scoreValue1)// player 1 score
    {
        score1 = score1 + scoreValue1;
        score1Text.text = score1.ToString();
        ResetGame();
        if (score1 == 5)
        {
            resetPanel.SetActive(true);
            Debug.Log("Player 1 WON");
        }
    }

    public void Score2Calculator(int scoreValue2)// player 2 score 
    {
        score2 = score2 + scoreValue2;
        score2Text.text = score2.ToString();
        ResetGame();
        if (score2 == 5)
        {
            resetPanel.SetActive(true);
            Debug.Log("Player 2 WON");
        }
    }
    public void TaskOnClick()// restating game when player clicks reset button.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ResetGame()
    {
        ball.RestartPosition();
    }

}


