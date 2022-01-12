using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore2 : MonoBehaviour
{
    public Text highscore;

    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore2", 0).ToString();
    }

}
