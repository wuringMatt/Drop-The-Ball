using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brainDetector_dropTheBall : MonoBehaviour
{
    public AudioSource source;
    public AudioClip Audio;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("missed"))
        {
            Debug.Log("Missed");
        } else if (collision.gameObject.tag.Equals("hit"))
        {
            Debug.Log("Hit");
            source.clip = Audio;
            source.Play();
            GameManager.instance.SetWon(true);
        }
    }
}
