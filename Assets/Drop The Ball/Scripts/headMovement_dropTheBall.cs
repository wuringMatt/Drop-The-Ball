using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headMovement_dropTheBall : MonoBehaviour
{
    float x, y;
    bool left = false, right = false;

    void Start()
    {
        left = true;
        GameManager.instance.StartGame(7f, false, "drop it!");
    }

    void Update()
    {
        gameObject.transform.position = new Vector2(x, y);
        if (left == true)
        {
            x = x - 0.01f;
        } else if(right == true)
        {
            x = x - -0.01f;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Equals("detector left"))
        {
            left = false;
            right = true;
        } else if(collision.gameObject.name == "detector right")
        {
            left = true;
            right = false;
        }
    }
}
