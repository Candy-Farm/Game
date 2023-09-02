using System;
using System.Collections;
using System.Collections.Generic;
using Models;
using UnityEngine;

[Serializable]
public class PlayerManager
{
    public PlayerDataSO PlayerData;

    public Item[] playerItems;
    


    public Sprite GetProfilePicture(int Index)
    {
        return GameManager.Instance.profilePicDataSO.GetImage(Index);
    }
}
