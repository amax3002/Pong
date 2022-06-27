using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Ball ball;

    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerscoreText;
    public Text computerscoreText;

    private int _playerScore;

    private int _computerScore;


    public void PlayerScore()
    {
        _playerScore++;

        this.playerscoreText.text = _playerScore.ToString();
        ResetRound();
    }
    
    public void ComputerScore()
    {
        _computerScore++;

        this.computerscoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

}
