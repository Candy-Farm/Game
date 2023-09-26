using CandFarmEnums;
using UnityEngine;
using UnityEngine.Pool;

public class CandyItem : MonoBehaviour
{
    [HideInInspector]
    public CandyType candyType;

    private IObjectPool<CandyItem> candyItemPool;

    public void SetPool(IObjectPool<CandyItem> pool)
    {
        candyItemPool = pool;
    }

    public void updateCandyItem(Candy candy)
    {
        candyType = candy.candyType;
        GetComponent<SpriteRenderer>().sprite = candy.sprite;
    }

    private void OnBecameInvisible()
    {
        if (this.gameObject.activeSelf == false)
            candyItemPool.Release(this);
    }
}