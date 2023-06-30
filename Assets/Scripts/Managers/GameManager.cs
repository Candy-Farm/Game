using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public CandySO[] candySoCollection;
    public CandySO NftSo;
    public TargetSO targetCollectionSO;
    public Target currentTarget;
    public float maxTimer;
    float gameTimer = 0;

    bool startTimer = false;


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

        gameTimer = GameManager.instance.maxTimer;
        startTimer = true;
    }

    private void Update()
    {
        if (startTimer == true)
            updateTimer();
    }

    public void OnGameOver()
    {
        StopTimer();
        if (PlayerController.instance.winGame)
        {
            PlayerController.instance.collectedNftsCount += winBonus;
        }
        PlayerController.instance.canMove = false;
        FindAnyObjectByType<BackgroundAnimation>().isMoving = false;
        CandySpawnController.instance.stopSpawningCandies();
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
            GameManager.instance.OnGameOver();
        }
    }

    void StopTimer()
    {
        startTimer = false;
    }
}
