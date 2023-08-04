using System.Collections;
using System.Collections.Generic;
using AudioSettings;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] 
    GameObject TutorialPanel;

    [SerializeField]
    GameObject MenuPanel;
    void Start()
    {
        AudioManager.instance.PlaySound(AudioGroup.BgMusic, AudioClipNames.BgMusic.MenuMusic.ToString(), true);
        AudioManager.instance.PlayAmbience(true);
        // onCloseTutorialClicked();
    }
    public void onPlayGame()
    {
        AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
        SceneManager.LoadScene("Game");
    }
    public void onExit()
    {
        AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
        Application.Quit();
    }

    public void onTutorialClicked()
    {
        AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
        MenuPanel.SetActive(false);
        TutorialPanel.SetActive(true);
    }

    public void onCloseTutorialClicked()
    {
        AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
        MenuPanel.SetActive(true);
        TutorialPanel.SetActive(false);
    }
}
