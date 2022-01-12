using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetPoints : MonoBehaviour
{
    void Start()
    {
        ScoreTextScript.coinAmount = 0;
    }
}
