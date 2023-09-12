
using Models;

public class TargetCandyMode : IBattleModeBase
{
    public bool IntializeBattleData(CampaignStage stageData)
    {
        return true;
    }

    public void OnGameOver()
    {
        throw new System.NotImplementedException();
    }

    public bool OnUpdate()
    {
        throw new System.NotImplementedException();
    }

    public bool StartBattl()
    {
        throw new System.NotImplementedException();
    }
}