using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Sound_Effect : MonoBehaviour
{
    public AudioSource audioPlayer;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collision_Tag")
        {
            audioPlayer.Play();
        }
    }
}
