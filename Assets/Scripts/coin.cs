using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class coin : MonoBehaviour
{
    //file does audio for coin object and destroys object when collided with, also lets player know a new spawn was madeS
    public AudioClip coinSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Platformer>() != null)
        {
            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(coinSound, this.transform.position);
        }
    }
}
