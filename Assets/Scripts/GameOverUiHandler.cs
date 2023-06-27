using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUiHandler : MonoBehaviour
{

    [SerializeField]
    GameObject rewardsContainer;

    public static GameOverUiHandler instance;

    private void Awake()
    {
        instance = this;
    }

    public void ActivateWinPanel(bool activate)
    {
        rewardsContainer.SetActive(activate);
    }

}
