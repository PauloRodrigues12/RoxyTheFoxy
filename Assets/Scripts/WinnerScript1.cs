using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinnerScript1 : MonoBehaviour
{
    public int winScene;
    public Text score1;
    int number1;

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(winScene);
        int.TryParse(score1.text, out number1);
        PlayerPrefs.SetInt("HighScore1", number1);
        Debug.Log("Score1 Guardado!");
    }
}
