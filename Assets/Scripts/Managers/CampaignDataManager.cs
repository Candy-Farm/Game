using System.Linq;
using GameData.CampaignDesign;
using UnityEngine;

public class CampaignDataManager
{
    StageModel[] stages;


    public StageModel GetStage(int index) => stages.FirstOrDefault(x => x.stageIndex == index);


    public StageModel[] GetAllStages() => (stages.Length > 0) ? stages : null;

    public bool CheckStageCompletion(int index) => stages.FirstOrDefault(x => x.stageIndex == index).iscompleted;

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