using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiHandler : MonoBehaviour
{
    [SerializeField]
    GameObject LifeLine;

    [SerializeField]
    GameObject GameOverPanel;

    [SerializeField]
    Slider timerProgressBar;
    public static UiHandler instance;

    public TextMeshProUGUI targetText;
    public Image targetImage;

    float gameTimer = 0;

    bool startTimer = false;

    [SerializeField]
    float maxTimer;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        GameOverPanel.SetActive(false);
        gameTimer = maxTimer;
        startTimer = true;
    }

    private void Update()
    {
        if (startTimer == true)
            updateTimer();
    }

    public void updateLifeUi()
    {
        int index = LifeLine.transform.childCount - 1;
        Destroy(LifeLine.transform.GetChild(index).gameObject);
    }

    public void updateTargetUi(Target target)
    {
        targetText.text = target.amount.ToString();
        targetImage.sprite = Array.Find(GameManager.instance.candySoCollection, (item) => item.candyType == target.cadnyType).candyImage;
    }


    public void ActivateGameOverPanel()
    {
        GameOverPanel.SetActive(true);
        GameOverUiHandler.instance.ActivateWinPanel(PlayerController.instance.winGame);
    }

    public void updateTimer()
    {
        gameTimer -= 2 * Time.deltaTime;

        float progress = (gameTimer / maxTimer);
        print(Math.Round(gameTimer));
        print(progress);

        // Mathf.Lerp(progress, (gameTimer / maxTimer),);
        timerProgressBar.value = progress;

        if (gameTimer <= 0)
        {
            startTimer = false;
            GameManager.instance.OnGameOver();
        }
    }

}
