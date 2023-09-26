using Models;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [HideInInspector]
    public BattleModeBase battleMode;

    InGamePlayerDetails inGamePlayer;
    public CampaignStage stageData;
    private void Awake()
    {
        stageData = CampaignDataManager.Instance.GetCurrentStage();
        if (battleMode == null)
        {
            battleMode = new GameObject("GameMode").AddComponent<EscapeBombMode>();
            battleMode.transform.parent = this.transform;
            battleMode.LoadStageData(stageData);
        }
        inGamePlayer = new InGamePlayerDetails();
        inGamePlayer.SetupPlayer(100, 100);
    }



    public InGamePlayerDetails GetInGamePlayer()
    {
        return inGamePlayer;
    }
}


public class InGamePlayerDetails
{
    float currentHp;
    float maxHp;

    public void LooseHealth()
    {
        float healthLoss = maxHp / 5;
        currentHp -= healthLoss;
    }

    public void SetupPlayer(float currentHp, float maxHp)
    {
        this.currentHp = currentHp;
        this.maxHp = maxHp;
    }

    public void GainHealth()
    {
        float healthLoss = maxHp / 5;
        currentHp += healthLoss;
    }
}