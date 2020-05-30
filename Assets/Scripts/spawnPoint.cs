using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{
    private Transform tf;

    private void Start()
    {
        tf = GetComponent<Transform>();
    }
    //sets spawn point for player in case of die function and gives die the location of spawn for the player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Platformer>() != null)
        {
            collision.GetComponent<Platformer>().spawnPoint = this.tf;
        }
    }
}
