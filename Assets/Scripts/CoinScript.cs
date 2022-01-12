﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            AudioManager.PlaySound("CoinSound");
            ScoreTextScript.coinAmount += 1;
            Destroy(gameObject);
        }
    }
}
