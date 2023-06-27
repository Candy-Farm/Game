using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }

    private void Update()
    {

    }

    public void OnGameOver()
    {
        CandySpawnController.instance.stopSpawningCandies();
        UiHandler.instance.ActivateGameOverPanel();
    }
}
