using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverUiHandler : MonoBehaviour
{

    [SerializeField]
    GameObject rewardsContainer;

    [SerializeField]
    TextMeshProUGUI nftCountTextUi;

    public static GameOverUiHandler instance;

    private void Awake()
    {
        instance = this;
    }

    public void ActivateWinPanel(bool activate)
    {
        nftCountTextUi.text = PlayerController.instance.collectedNftsCount.ToString();
        rewardsContainer.SetActive(activate);
    }

}
