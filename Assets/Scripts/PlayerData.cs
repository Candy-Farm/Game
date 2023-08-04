using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CandFarmEnums;

public class PlayerData
{
    private string playerId;
    private string playerName;
    private int playerLevel;
    private PlayerRank rank;

    public void LoadPlayerData(PlayerData playerData)
    {
        playerId = playerData.playerId;
        playerName = playerData.playerName;
        rank = playerData.rank;
        playerLevel = playerData.playerLevel;
    }
}
