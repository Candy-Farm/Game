using System.Collections.Generic;
using System.Linq;
using CandFarmEnums;
using Models;
using UnityEngine;

public class CampaignDataManager : Singleton<CampaignDataManager>
{
    public CampaignStage[] campaignStages;

    private void Awake()
    {
        LoadCampaignData();
    }
    void LoadCampaignData()
    {
        campaignStages = new CampaignStage[]{
            new CampaignStage(){
                stageIndex=1,
                gameType=GameType.TargetCandyMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies=50
                    {CandyType.Bomb,10},
                    {CandyType.firstCandy,15},
                    {CandyType.secondCandy,15},
                    {CandyType.thirdCandy,10},
                },
                // targetCandy=new KeyValuePair<CandyType, int>(CandyType.firstCandy,5)
            },
            new CampaignStage(){
                stageIndex=2,
                gameType=GameType.EscapeBombMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies100
                    {CandyType.Bomb,20},
                    {CandyType.firstCandy,20},
                    {CandyType.secondCandy,20},
                    {CandyType.thirdCandy,20},
                    {CandyType.forthCandy,20},
                }
            },
            new CampaignStage(){
                stageIndex=3,
                gameType=GameType.WaveMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies100
                    {CandyType.Bomb,10},
                    {CandyType.firstCandy,20},
                    {CandyType.secondCandy,20},
                    {CandyType.thirdCandy,25},
                    {CandyType.forthCandy,25},

                }
            },
            new CampaignStage(){
                stageIndex=4,
                gameType=GameType.FastPaceMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies200
                    {CandyType.firstCandy,50},
                    {CandyType.secondCandy,50},
                    {CandyType.thirdCandy,50},
                    {CandyType.forthCandy,50},
                }
            },
            new CampaignStage(){
                stageIndex=5,
                gameType=GameType.WaveMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies150
                    {CandyType.Bomb,15},
                    {CandyType.secondCandy,35},
                    {CandyType.thirdCandy,50},
                    {CandyType.forthCandy,50},
                }
            },
            new CampaignStage(){
                stageIndex=6,
                gameType=GameType.TargetCandyMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies=100
                    {CandyType.Bomb,17},
                    {CandyType.firstCandy,35},
                    {CandyType.secondCandy,35},
                    {CandyType.forthCandy,13},
                },
                // targetCandy=new KeyValuePair<CandyType, int>(CandyType.forthCandy,10)
            },
            new CampaignStage(){
                stageIndex=7,
                gameType=GameType.TargetCandyMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies=120
                    {CandyType.Bomb,20},
                    {CandyType.firstCandy,21},
                    {CandyType.secondCandy,40},
                    {CandyType.thirdCandy,39},
                },
                // targetCandy=new KeyValuePair<CandyType, int>(CandyType.forthCandy,10)
            },
            new CampaignStage(){
                stageIndex=8,
                gameType=GameType.WaveMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies=120
                    {CandyType.Bomb,30},
                    {CandyType.firstCandy,20},
                    {CandyType.secondCandy,20},
                    {CandyType.thirdCandy,20},
                    {CandyType.forthCandy,30}
                },
            },
            new CampaignStage(){
                stageIndex=9,
                gameType=GameType.EscapeBombMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies=150
                    {CandyType.Bomb,50},
                    {CandyType.firstCandy,50},
                    {CandyType.thirdCandy,25},
                    {CandyType.forthCandy,25},
                },
            },
            new CampaignStage(){
                stageIndex=10,
                gameType=GameType.FastPaceMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies=90
                    {CandyType.Bomb,15},
                    {CandyType.firstCandy,30},
                    {CandyType.thirdCandy,30},
                    {CandyType.forthCandy,15},
                },
            },
            new CampaignStage(){
                stageIndex=11,
                gameType=GameType.EscapeBombMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies=70
                    {CandyType.Bomb,70},
                },
            },
            new CampaignStage(){
                stageIndex=12,
                gameType=GameType.FastPaceMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies=90
                    {CandyType.Bomb,40},
                    {CandyType.firstCandy,40},
                    {CandyType.secondCandy,40},
                    {CandyType.thirdCandy,40},
                    {CandyType.forthCandy,40},
                },
            },
        };
    }

    public CampaignStage GetStage(int index) => campaignStages.FirstOrDefault(x => x.stageIndex == index);


    public CampaignStage[] GetAllStages() => (campaignStages.Length > 0) ? campaignStages : null;

    public bool CheckStageCompletion(int index) => campaignStages.FirstOrDefault(x => x.stageIndex == index).iscompleted;

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