using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreen : MonoBehaviour
{
    public GameObject Screen;
    public GameObject ThisScreen;

    public void changescreen()
    {
        Screen.SetActive(true);
        ThisScreen.SetActive(false);
    }
}
