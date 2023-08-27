using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class GameManager : Singleton<GameManager>
{
    public ProfilePictureDataSO profilePicDataSO;

    MenuHandler mainMenu;
    public PlayerManager player;
    void Awake()
    {
        mainMenu = new MenuHandler();
        // player.PlayerData = new PlayerData();
    }

    void Start()
    {

    }

}
