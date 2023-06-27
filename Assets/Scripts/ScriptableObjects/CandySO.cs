using System.Collections;
using System.Collections.Generic;
using Candies;
using UnityEngine;

[CreateAssetMenu(fileName = "", menuName = "CandyFarm/Candy")]
public class CandySO : ScriptableObject
{
    [SerializeField]
    CandyType candyType;

    [SerializeField]
    Sprite candyImage;
    
}
