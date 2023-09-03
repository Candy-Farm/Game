using System.Collections;
using System.Collections.Generic;
using AudioSettings;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUiManager : MonoBehaviour
{

    [Header("Player Profile")]
    [SerializeField]
    Image PlayerProfilePic;
    [SerializeField]
    TextMeshProUGUI playerNameText;
    [SerializeField]
    TextMeshProUGUI playerLevelText;


    void Start()
    {
        Invoke(nameof(init), (AudioManager.Instance == null) ? 5 : 0);
        UpdateUserProfileUi();

    }

    void init()
    {
        AudioManager.Instance.PlaySound(AudioGroup.BgMusic, AudioClipNames.BgMusic.MenuMusic.ToString(), true);
        AudioManager.Instance.PlayAmbience(true);
    }
    public void onPlayGame()
    {
        AudioManager.Instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
        SceneManager.LoadScene("Game");
    }
    // public void onExit()
    // {
    //     AudioManager.Instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
    //     Application.Quit();
    // }

    // public void onTutorialClicked()
    // {
    //     AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
    //     MenuPanel.SetActive(false);
    //     TutorialPanel.SetActive(true);
    // }

    // public void onCloseTutorialClicked()
    // {
    //     AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
    //     MenuPanel.SetActive(true);
    //     TutorialPanel.SetActive(false);
    // }

    private void UpdateUserProfileUi()
    {
        PlayerManager player = MenuHandler.Instance.GetPlayer();
        var playerData = player.PlayerData;
        PlayerProfilePic.sprite = GameManager.Instance.GetProfilePicture(playerData.pictureIndex);
        playerNameText.text = playerData.playerName;
        playerLevelText.text = "Lvl " + playerData.playerLevel.ToString();

    }
}
