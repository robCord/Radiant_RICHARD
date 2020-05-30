using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killZone : MonoBehaviour
{
    //Should player fall on kill zone a die function is called 
    // any kill zone touches will result in the loss of a life 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.GetComponent<Platformer>().Die();
        }
    }
}
