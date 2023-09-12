using System;
using System.Collections;
using System.Collections.Generic;
using CandFarmEnums;
using Models;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class GameManager : Singleton<GameManager>
{
    public ProfilePictureDataSO profilePicDataSO;

    public PlayerManager player;
    CampaignData campaignData;

    MenuHandler mainMenu;
    void Awake()
    {
        LoadPlayerData();
        LoadCampaignData();
        mainMenu = new MenuHandler();
    }

    void Start()
    {

    }

    public void LoadPlayerData()
    {
        player = new PlayerManager()
        {
            PlayerData = null,

        };
        GameResourceManager.Instance.GetPlayerData((playerData) =>
        {
            player.PlayerData = playerData;
        });

    }

    public void LoadCampaignData()
    {
        campaignData = new CampaignData();
    }

    public Sprite GetProfilePicture(int Index)
    {
        return profilePicDataSO.GetImage(Index);
    }
}
