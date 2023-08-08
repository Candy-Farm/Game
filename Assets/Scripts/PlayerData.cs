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
    public PlayerRank rank;

    public void LoadPlayerData(PlayerData playerData)
    {
        playerId = playerData.playerId;
        playerName = playerData.playerName;
        rank = playerData.rank;
        playerLevel = playerData.playerLevel;
    }
}
