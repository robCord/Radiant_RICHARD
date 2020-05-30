using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryArea : MonoBehaviour
{
    //should player come in contact to win condition game is over and win scene is shown
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Platformer player = collision.GetComponent<Platformer>();
        if (player != null)
        {
            player.Victory();
        }
    }
}
