using UnityEngine;
using Models;
using Unity.VisualScripting;

public class EscapeBombMode : BattleModeBase
{
    public void IntializeBattleData(CampaignStage stageData)
    {

    }

    // private void Start()
    // {
    // }
    public override void LoadStageData(CampaignStage stageData)
    {
    }

    public void OnGameOver()
    {
        throw new System.NotImplementedException();
    }

    public void OnUpdateCandySpawn()
    {
        spawner.candyItemPool.Get();
    }

    public bool StartBattle()
    {
        throw new System.NotImplementedException();
    }


}