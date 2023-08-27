using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "", menuName = "CandyFarm/PlayerManager")]
public class PlayerManager : ScriptableObject
{
    public PlayerData PlayerData;
    
    public Sprite GetProfilePicture(int Index)
    {
        return GameManager.Instance.profilePicDataSO.GetImage(Index);
    }
}
