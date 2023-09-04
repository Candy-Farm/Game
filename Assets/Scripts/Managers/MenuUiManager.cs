using System.Collections;
using System.Collections.Generic;
using AudioSettings;
using CandFarmEnums;
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

    public void EnterInventory()
    {
        SceneManager.LoadScene(SceneNames.Inventory.ToString());
    }

    public void EnterLeaderboard()
    {
        SceneManager.LoadScene(SceneNames.Leaderboard.ToString());
    }

    public void EnterProfile()
    {
        SceneManager.LoadScene(SceneNames.Userprofile.ToString());
    }

    public void EnterTutorial()
    {
        SceneManager.LoadScene(SceneNames.Tutorial.ToString());
    }

    public void EnterShop()
    {
        SceneManager.LoadScene(SceneNames.Store.ToString());
    }


    private void UpdateUserProfileUi()
    {
        PlayerManager player = MenuHandler.Instance.GetPlayer();
        // var playerData = player.PlayerData;
        // PlayerProfilePic.sprite = GameManager.Instance.GetProfilePicture(playerData.pictureIndex);
        // playerNameText.text = playerData.playerName;
        // playerLevelText.text = "Lvl " + playerData.playerLevel.ToString();

    }
}
