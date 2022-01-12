using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore3 : MonoBehaviour
{
    public Text highscore;

    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore3", 0).ToString();
    }

}
