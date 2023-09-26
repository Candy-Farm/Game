using UnityEngine;
using Models;
using Unity.VisualScripting;
using CandFarmEnums;

public class EscapeBombMode : BattleModeBase
{
    public void IntializeBattleData(CampaignStage stageData)
    {

    }

    public void OnGameOver()
    {
        throw new System.NotImplementedException();
    }

    public void UpdateGamePlay(CandyItem candyItem)
    {
        if (candyItem.candyCaught == true)
        {
            if (candyItem.candyType == CandyType.Bomb)
            {
                battleManager.GetInGamePlayer().LooseHealth();
            }
        }
        else
        {
            if (candyItem.candyType != CandyType.Bomb)
            {
                //loose life
            }
        }
    }

    void processCandySpawning()
    {
        // interval = (StageData.timeSpan * 60 / StageData.battleCandies.Sum(x => x.Value));
        // InvokeRepeating(nameof(SpawnCandy), 1, interval);
    }
}