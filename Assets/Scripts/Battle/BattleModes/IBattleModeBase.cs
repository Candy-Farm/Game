using System.Collections;
using System.Collections.Generic;
using CandFarmEnums;
using Models;
using UnityEngine;

public interface IBattleModeBase
{
    public bool IntializeBattleData(CampaignStage stageData);
    public bool StartBattle();
    public bool OnUpdate();
    public void OnGameOver();
}
