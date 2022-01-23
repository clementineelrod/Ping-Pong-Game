

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerScore;
    private int computerScore;
    public Ball ball;
    public Text playerScore1;
    public Text computerScore2;
    public Paddle playerpad;
    public Paddle computerpad;
    public void player()
    {
        playerScore++;
        Debug.Log(playerScore);
        this.playerScore1.text = playerScore.ToString();
        this.playerpad.ResetPosition();
        this.computerpad.ResetPosition();
        this.ball.ResetPosition();
        this.ball.addForce();
        

    }
    public void computer()
    {
        computerScore++;
        Debug.Log(computerScore);
        this.computerScore2.text = computerScore.ToString();
        this.playerpad.ResetPosition();
        this.computerpad.ResetPosition();
        this.ball.ResetPosition();
        this.ball.addForce();

    }

}
