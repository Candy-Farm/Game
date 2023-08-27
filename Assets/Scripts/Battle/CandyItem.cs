using CandFarmEnums;
using UnityEngine;

public class CandyItem : MonoBehaviour
{
    [HideInInspector]
    public CandyType candyType;


    public void updateCandyItem(Candy candy)
    {
        candyType = candy.candyType;
        GetComponent<SpriteRenderer>().sprite = candy.sprite;
    }
}