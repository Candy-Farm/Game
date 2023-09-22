using UnityEngine;
using Models;
using Unity.VisualScripting;

public class EscapeBombMode : BattleModeBase
{
    public bool IntializeBattleData(CampaignStage stageData)
    {
        return true;
    }

    private void Start()
    {
        
    }
    public void OnGameOver()
    {
        throw new System.NotImplementedException();
    }

    public bool OnUpdate()
    {
        throw new System.NotImplementedException();
    }

    public bool StartBattle()
    {
        throw new System.NotImplementedException();
    }
}