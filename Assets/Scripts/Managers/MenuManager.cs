using System.Collections;
using System.Collections.Generic;
using AudioSettings;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class MenuManager : MonoBehaviour
{

    [SerializeField]
    GameObject TutorialPanel;

    [SerializeField]
    GameObject MenuPanel;

    [Header("Player Profile")]
    [SerializeField]
    Image PlayerProfilePic;
    [SerializeField]
    TextMeshProUGUI playerNameText;
    [SerializeField]
    TextMeshProUGUI playerLevelText;

    [Header("Player Ranking")]
    [SerializeField]
    RadialSlider playerExpProgress;
    [SerializeField]
    Image PlayerRankImage;


    void Start()
    {
        Invoke(nameof(init), (AudioManager.instance == null) ? 5 : 0);
        // onCloseTutorialClicked();
    }

    void init()
    {
        AudioManager.instance.PlaySound(AudioGroup.BgMusic, AudioClipNames.BgMusic.MenuMusic.ToString(), true);
        AudioManager.instance.PlayAmbience(true);
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
