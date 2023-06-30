using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public CandySO[] candySoCollection;
    public TargetSO targetCollectionSO;
    public Target currentTarget;


    List<Candy> candyCollection;

    private void Awake()
    {
        instance = this;
        candyCollection = new List<Candy>();
    }
    void Start()
    {
        currentTarget = new Target();
        currentTarget.updateData(targetCollectionSO.GetRandomTarget());
        UiHandler.instance.updateTargetUi(currentTarget);
    }

    public void OnGameOver()
    {
        PlayerController.instance.canMove = false;
        FindAnyObjectByType<BackgroundAnimation>().isMoving = false;
        CandySpawnController.instance.stopSpawningCandies();
        UiHandler.instance.ActivateGameOverPanel();
    }


}
