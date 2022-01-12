using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive;

    private PlayerMovement player;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
            other.gameObject.GetComponent<PlayerMovement>().HitPlayer();            
        }
    }
}
