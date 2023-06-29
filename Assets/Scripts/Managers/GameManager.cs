using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public CandySO[] candySoCollection;
    public TargetSO targetSO;
    public Target currentTarget;

    [HideInInspector]
    public List<Candy> candyCollection;

    private void Awake()
    {
        instance = this;
        candyCollection = new List<Candy>();
    }
    void Start()
    {
        currentTarget = new Target();
        currentTarget.cadnyType = targetSO.GetRandomTarget().cadnyType;
        currentTarget.amount = targetSO.GetRandomTarget().amount;
    }

    public void OnGameOver()
    {
        CandySpawnController.instance.stopSpawningCandies();
        UiHandler.instance.ActivateGameOverPanel();
    }


}
