using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinnerScript2 : MonoBehaviour
{
    public int winScene;
    public Text score2;
    int number2;

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(winScene);
        int.TryParse(score2.text, out number2);
        PlayerPrefs.SetInt("HighScore2", number2);
        Debug.Log("Score2 Guardado!");
    }
}