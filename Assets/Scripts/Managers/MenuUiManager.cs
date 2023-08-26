using System.Collections;
using System.Collections.Generic;
using AudioSettings;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUiManager : MonoBehaviour
{

    // [SerializeField]
    // GameObject TutorialPanel;

    // [SerializeField]
    // GameObject MenuPanel;

    // [Header("Player Profile")]
    // [SerializeField]
    // Image PlayerProfilePic;
    // [SerializeField]
    // TextMeshProUGUI playerNameText;
    // [SerializeField]
    // TextMeshProUGUI playerLevelText;

    // [Header("Player Ranking")]
    // // [SerializeField]
    // // RadialSlider playerExpProgress;
    // [SerializeField]
    // Image PlayerRankImage;


    // void Start()
    // {
    //     Invoke(nameof(init), (AudioManager.instance == null) ? 5 : 0);
    //     UpdateUserProfileUi();
    // }

    // void init()
    // {
    //     AudioManager.instance.PlaySound(AudioGroup.BgMusic, AudioClipNames.BgMusic.MenuMusic.ToString(), true);
    //     AudioManager.instance.PlayAmbience(true);
    // }
    // public void onPlayGame()
    // {
    //     AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
    //     SceneManager.LoadScene("Game");
    // }
    // public void onExit()
    // {
    //     AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.ButtoClick.ToString());
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

    // private void UpdateUserProfileUi()
    // {
    //     var manager = GameManager.instance;
    //     // print(manager.player.PlayerData);
    //     PlayerProfilePic.sprite = GameManager.instance.profilePicDataSO.GetImage(manager.player.PlayerData.pictureIndex);
    //     playerNameText.text = manager.player.PlayerData.playerName;
    //     playerLevelText.text = "Lv " + manager.player.PlayerData.playerLevel.ToString();

    // }
}
