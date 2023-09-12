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

    [SerializeField]
    public PlayerManager player;


    MenuHandler mainMenu;
    void Awake()
    {
        LoadPlayerData();
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

    }

    public Sprite GetProfilePicture(int Index)
    {
        return profilePicDataSO.GetImage(Index);
    }
}
