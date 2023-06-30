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
    public static UiHandler instance;

    public TextMeshProUGUI targetText;
    public Image targetImage;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        GameOverPanel.SetActive(false);
    }

    public void updateLifeUi()
    {
        int index = LifeLine.transform.childCount - 1;
        Destroy(LifeLine.transform.GetChild(index).gameObject);
    }

    public void updateTargetUi(Target target)
    {
        print(target.amount + " " + target.cadnyType);
        targetText.text = target.amount.ToString();
        targetImage.sprite = Array.Find(GameManager.instance.candySoCollection, (item) => item.candyType == target.cadnyType).candyImage;
    }


    public void ActivateGameOverPanel()
    {
        GameOverPanel.SetActive(true);
        GameOverUiHandler.instance.ActivateWinPanel(PlayerController.instance.winGame);
    }
}
