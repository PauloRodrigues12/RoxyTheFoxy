using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinnerScript3 : MonoBehaviour
{
    public int winScene;
    public Text score3;
    int number3;

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(winScene);
        int.TryParse(score3.text, out number3);
        PlayerPrefs.SetInt("HighScore3", number3);
        Debug.Log("Score3 Guardado!");
    }
}
