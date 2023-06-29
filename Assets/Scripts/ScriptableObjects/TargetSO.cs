using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Candies;
using System;

[CreateAssetMenu(fileName = "", menuName = "CandyFarm/Target")]

public class TargetSO : ScriptableObject
{
    [SerializeField]
    Target[] targets;


    public Target GetTarget(int index)
    {
        return targets[index];
    }

    public Target GetRandomTarget()
    {
        int randonIndex = UnityEngine.Random.Range(0, targets.Length);
        Target randomTarget = GetTarget(randonIndex);
        return randomTarget;
    }
}

[Serializable]
public class Target
{
    public CandyType cadnyType;
    public int amount;
}
