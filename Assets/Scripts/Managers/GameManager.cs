using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    CandySO[] candySoCollection;

    public List<Candy> candyCollection;

    private void Awake()
    {
        candyCollection = new List<Candy>();
        instance = this;
    }
    void Start()
    {

    }

    public void OnGameOver()
    {
        CandySpawnController.instance.stopSpawningCandies();
        UiHandler.instance.ActivateGameOverPanel();
    }

    void CreateCandy()
    {
        Candy candy = new Candy();
    }
}
