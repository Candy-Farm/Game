using System.Collections;
using System.Collections.Generic;
using AudioSettings;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{


    void Start()
    {

    }
    public void onPlayGame()
    {
        // AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
        SceneManager.LoadScene("Game");
    }

    public void onTutorial()
    {
        AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
    }

    public void onExit()
    {
        AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
        Application.Quit();
    }
}
