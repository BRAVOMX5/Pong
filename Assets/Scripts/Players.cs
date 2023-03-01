using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float speed = 1f;
    public bool Player1;

    // Update is called once per frame
    void Update()
    {
        float movement;

        if (Player1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        
        transform.position += new Vector3(0, movement * speed * Time.deltaTime, 0);
    }

}
