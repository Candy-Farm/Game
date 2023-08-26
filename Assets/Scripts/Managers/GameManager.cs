using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ProfilePictureDataSO profilePicDataSO;
    public static GameManager instance;

    public PlayerManager player;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // player.PlayerData = new PlayerData();
    }


}
