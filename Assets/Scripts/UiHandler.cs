using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiHandler : MonoBehaviour
{
    [SerializeField]
    GameObject LifeLine;

    [SerializeField]
    GameObject GameOverPanel;
    public static UiHandler instance;
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


    public void ActivateGameOverPanel()
    {
        GameOverPanel.SetActive(true);
        GameOverUiHandler.instance.ActivateWinPanel(PlayerController.instance.winGame);
    }
}
