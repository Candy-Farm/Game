using System.Collections;
using System.Collections.Generic;
using CandFarmEnums;
using Models;
using UnityEngine;

public class BattleModeBase : MonoBehaviour
{
    internal CandySpawnController spawner;
    public CampaignStage currentStage;

    private void Awake()
    {
        spawner = FindObjectOfType<CandySpawnController>();
        currentStage = FindObjectOfType<BattleManager>().stageData;
    }
    private void Start()
    {
        if (currentStage != null)
            LoadStageData(currentStage);
    }

    public virtual void LoadStageData(CampaignStage stageData)
    {

    }
}
