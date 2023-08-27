using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CandFarmEnums;
using System;

[Serializable]
public class PlayerData
{
    public string playerId;
    public string playerName;
    public int playerLevel;
    public float expLevel;
    public int pictureIndex;

    public void LoadPlayerData(PlayerData playerData)
    {
        playerId = playerData.playerId;
        playerName = playerData.playerName;
        expLevel = playerData.expLevel;
        playerLevel = playerData.playerLevel;
        pictureIndex = playerData.pictureIndex;
    }
}
