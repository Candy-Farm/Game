using UnityEngine;

public class MenuHandler
{
    public static MenuHandler Instance;


    public MenuHandler()
    {
        if (Instance == null)
            Instance = this;
    }

    public PlayerManager GetPlayer()
    {
        PlayerManager playerData = GameManager.Instance.player;
        return playerData;
    }

}