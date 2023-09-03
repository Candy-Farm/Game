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

    MenuHandler mainMenu;
    public PlayerManager player;
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
            playerItems = new Item[]{
                new Item{
                    itemName=ItemType.Speed.ToString(),
                    itemDescription="the speed item manipulates the speed of a falling candy in the game so it doesn't fall too fast",
                    itemAmount=200f,
                    itemType=ItemType.Speed
                },
                new Item{
                    itemName=ItemType.Magnet.ToString(),
                    itemDescription="the Magnet item manipulates the Magnet of a falling candy in the game so it doesn't fall too fast",
                    itemAmount=200f,
                    itemType=ItemType.Magnet
                },
                new Item{
                    itemName=ItemType.booster.ToString(),
                    itemDescription="the booster item manipulates the booster of a falling candy in the game so it doesn't fall too fast",
                    itemAmount=200f,
                    itemType=ItemType.booster
                },
                new Item{
                    itemName=ItemType.HealthBackupKey.ToString(),
                    itemDescription="the HealthBackupKey item manipulates the HealthBackupKey of a falling candy in the game so it doesn't fall too fast",
                    itemAmount=200f,
                    itemType=ItemType.HealthBackupKey
                },
            }
        };
    }

    public void LoadCampaignData(){

    }
}
