using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game_Manager : MonoBehaviour
{
    public TMP_Text Player1ScoreText;
    public TMP_Text Player2ScoreText;

    public Transform Player1Transform;
    public Transform Player2Transform;
    public Transform ballTransform;

    private int Player1Score;
    private int Player2Score;

    public static Game_Manager instance;

    public static Game_Manager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<Game_Manager>();
            }
            return instance;
        }
    }

    public void Player1Scores()
    {
        Player1Score ++;
        Player1ScoreText.text = Player1Score.ToString();
    }

    public void Player2Scores()
    {
        Player2Score++;
        Player2ScoreText.text = Player2Score.ToString();
    }

    public void Restart()
    {
        Player1Transform.position = new Vector2(Player1Transform.position.x, 0);
        Player2Transform.position = new Vector2(Player2Transform.position.x, 0);
        ballTransform.position = new Vector2(0, 0);
    }
}
