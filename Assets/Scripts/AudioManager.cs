using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public static AudioClip playerHitSound, jumpSound, backMusic, mousedeathsound, eagledeathsound, coinsound, cherrysound;
    static AudioSource audioSrc;

    void Start()
    {
        playerHitSound = Resources.Load<AudioClip>("HurtSound");
        jumpSound = Resources.Load<AudioClip>("JumpSound");
        backMusic = Resources.Load<AudioClip>("TutorialBGmusic");
        mousedeathsound = Resources.Load<AudioClip>("MouseDeath");
        eagledeathsound = Resources.Load<AudioClip>("EagleDeath");
        coinsound = Resources.Load<AudioClip>("CoinSound");
        cherrysound = Resources.Load<AudioClip>("CherrySound");

        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "HurtSound":
                audioSrc.PlayOneShot(playerHitSound);
                break;
            case "JumpSound":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "TutorialBGmusic":
                audioSrc.PlayOneShot(backMusic);
                break;
            case "MouseDeath":
                audioSrc.PlayOneShot(mousedeathsound);
                break;
            case "EagleDeath":
                audioSrc.PlayOneShot(eagledeathsound);
                break;
            case "CoinSound":
                audioSrc.PlayOneShot(coinsound);
                break;
            case "CherrySound":
                audioSrc.PlayOneShot(cherrysound);
                break;
        }
    }
}
