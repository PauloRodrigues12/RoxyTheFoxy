using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore1 : MonoBehaviour
{
    public Text highscore;

    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore1", 0).ToString();
    }

}
