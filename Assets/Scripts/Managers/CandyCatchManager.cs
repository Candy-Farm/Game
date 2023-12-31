using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CandyCatchManager : MonoBehaviour
{
    public static CandyCatchManager instance;
    public CandySO[] candySoCollection;
    public CandySO NftSo;
    public TargetSO targetCollectionSO;
    public Target currentTarget;
    public float maxTimer;
    float gameTimer = 0;

    bool startTimer = false;

    public bool gameOver;
    public int winBonus;


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

        gameTimer = CandyCatchManager.instance.maxTimer;
        startTimer = true;
        // OnGameOver();
    }

    private void Update()
    {
        if (startTimer == true)
            updateTimer();
    }

    public void OnGameOver()
    {
        gameOver = true;
        StopTimer();
        if (PlayerController.instance.winGame)
        {
            PlayerController.instance.collectedNftsCount += winBonus;
        }
        PlayerController.instance.canMove = false;
        FindAnyObjectByType<BackgroundAnimation>().isMoving = false;
        //CandySpawnController.instance.stopSpawningCandies();
        UiHandler.instance.ActivateGameOverPanel();
    }

    public void updateTimer()
    {
        gameTimer -= 2 * Time.deltaTime;
        float progress = (gameTimer / maxTimer);
        UiHandler.instance.timerProgressBar.value = progress;
        if (gameTimer <= 0)
        {
            startTimer = false;
            CandyCatchManager.instance.OnGameOver();
        }
    }

    void StopTimer()
    {
        startTimer = false;
    }
}
