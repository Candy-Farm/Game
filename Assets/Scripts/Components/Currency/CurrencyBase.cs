using CandFarmEnums;
using UnityEngine;

public class CurrencyBase
{
    public int amount;
    public CurrencyType currencyType;
    public string currencyName;
}

public class Gold : CurrencyBase
{
    public Gold(int amount)
    {
        this.amount = amount;
    }
}