using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong_Ball : MonoBehaviour
{
    public float inicialSpeed = 1f;
    private Rigidbody2D ballRb;
    public AudioSource PlayerAudio;
    public AudioSource ScoreAudio;
    public AudioSource WallAudio;

    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();
    }

    void Launch()
    {
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRb.velocity = new Vector2(xVelocity,yVelocity) * inicialSpeed;
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player1Score"))
        {
            Game_Manager.Instance.Player1Scores();
            Game_Manager.Instance.Restart();
            if (collision.gameObject.tag == "Player1Score")
            {
                ScoreAudio.Play();
            }
            Launch();
        }
        else
        {
            Game_Manager.Instance.Player2Scores();
            Game_Manager.Instance.Restart();
            if (collision.gameObject.tag == "Player2Score")
            {
                ScoreAudio.Play();
            }
            Launch();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collision_Tag")
        {
            PlayerAudio.Play();
        }

        if (collision.gameObject.tag == "Wall_Tag")
        {
            WallAudio.Play();
        }
    }

}
