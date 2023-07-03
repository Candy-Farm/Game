using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using AudioSettings;

public class UiHandler : MonoBehaviour
{
    [SerializeField]
    GameObject LifeLine;

    [SerializeField]
    GameObject GameOverPanel;

    // [SerializeField]
    public Slider timerProgressBar;
    public static UiHandler instance;

    public TextMeshProUGUI targetText;
    public Image targetImage;


    // [SerializeField]

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        GameOverPanel.SetActive(false);
        if (AudioManager.instance == null)
        {

        }
        else
        {
            AudioManager.instance.StopAudio(AudioGroup.Ambience);
            AudioManager.instance.PlayMusic(true);
        }

    }



    public void updateLifeUi()
    {
        int index = LifeLine.transform.childCount - 1;
        Destroy(LifeLine.transform.GetChild(index).gameObject);
    }

    public void updateTargetUi(Target target)
    {
        targetText.text = target.amount.ToString();
        targetImage.sprite = Array.Find(CandyCatchManager.instance.candySoCollection, (item) => item.candyType == target.cadnyType).candyImage;
    }


    public void ActivateGameOverPanel()
    {
        GameOverPanel.GetComponent<GameOverUiHandler>().AnimateGameOverPanel();
        // GameOverUiHandler.instance.ActivateWinPanel(PlayerController.instance.winGame);
    }



}
