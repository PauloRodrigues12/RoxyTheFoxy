using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    public GameObject PauseMenu;

    public void ClickPause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
