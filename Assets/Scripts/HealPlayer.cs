using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPlayer : MonoBehaviour
{
    public int healing;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            AudioManager.PlaySound("CherrySound");
            other.gameObject.GetComponent<PlayerHealthManager>().HealPlayer(healing);
            Destroy(gameObject);
        }
    }
}
