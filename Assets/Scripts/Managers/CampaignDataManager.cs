using System.Linq;
using Models;
using UnityEngine;

public class CampaignDataManager : Singleton<CampaignDataManager>
{
    CampaignData campaignData;

    private void Awake()
    {
        campaignData = new CampaignData();
    }

    public CampaignStage GetStage(int index) => campaignData.campaignStages.FirstOrDefault(x => x.stageIndex == index);


    public CampaignStage[] GetAllStages() => (campaignData.campaignStages.Length > 0) ? campaignData.campaignStages : null;

    public bool CheckStageCompletion(int index) => campaignData.campaignStages.FirstOrDefault(x => x.stageIndex == index).iscompleted;

    public void CompleteStage(int index)
    {
        var currentStage = GetStage(index);
        if (currentStage != null)
        {
            if (!CheckStageCompletion(index))
                currentStage.iscompleted = true;
        }
    }
}