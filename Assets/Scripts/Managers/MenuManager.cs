using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{


    void Start()
    {

    }
    public void onPlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void onTutorial()
    {

    }

    public void onExit()
    {

    }
}
