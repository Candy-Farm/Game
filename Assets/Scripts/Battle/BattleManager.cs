using Models;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [HideInInspector]
    public BattleModeBase battleMode;

    public CampaignStage stageData;
    private void Awake()
    {
        stageData = CampaignDataManager.Instance.GetCurrentStage();
        if (battleMode == null)
        {
            battleMode = new GameObject("GameMode").AddComponent<EscapeBombMode>();
            battleMode.transform.parent = this.transform;
            // Instantiate(battleMode, transform);
            // battleMode = obj.AddComponent<EscapeBombMode>();
            // Instantiate(battleMode, transform);
        }
    }
}