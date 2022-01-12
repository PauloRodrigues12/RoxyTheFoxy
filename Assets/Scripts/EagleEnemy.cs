using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleEnemy : MonoBehaviour
{
    public void Hurt()
    {
        AudioManager.PlaySound("EagleDeath");
        Destroy(this.gameObject);
    }
}
