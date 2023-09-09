using System.Collections.Generic;
using System.Linq;
using CandFarmEnums;
using GameData.CampaignDesign;
using Models;
using UnityEngine;

public class CampaignData
{
    public CampaignStage[] campaignStages;

    public CampaignData()
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
                targetCandy=new KeyValuePair<CandyType, int>(CandyType.firstCandy,5)
            },
            new CampaignStage(){
                stageIndex=2,
                gameType=GameType.EscapeBombMode,
                battleCandies=new Dictionary<CandyType, int>(){
                    //total candies100
                    {CandyType.Bomb,40},
                    {CandyType.firstCandy,15},
                    {CandyType.secondCandy,15},
                    {CandyType.thirdCandy,15},
                    {CandyType.forthCandy,15},
                }
            },
            new CampaignStage(){
                stageIndex=3,
                gameType=GameType.TargetCandyMode,
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
                    //total candies=150
                    {CandyType.Bomb,20},
                    {CandyType.firstCandy,35},
                    {CandyType.secondCandy,25},
                    {CandyType.thirdCandy,35},
                    {CandyType.forthCandy,15},
                },
                targetCandy=new KeyValuePair<CandyType, int>(CandyType.forthCandy,10)
            },
        };
    }
}