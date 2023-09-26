using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CandFarmEnums;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

public class CandySpawnController : MonoBehaviour
{

    [SerializeField]
    GameObject candyPrefab;

    [SerializeField]
    CandySO[] candySOs;

    BattleModeBase battleMode;
    public IObjectPool<CandyItem> candyItemPool;
    private void Awake()
    {
        candyItemPool = new ObjectPool<CandyItem>(CreateCandy, OnGet, OnRelease, OnDestroyCandy, maxSize: 5);

    }
    private void Start()
    {
        battleMode = FindFirstObjectByType<BattleManager>().battleMode;
    }

    private CandyItem CreateCandy()
    {

        CandyItem newCandy = Instantiate(candyPrefab).GetComponent<CandyItem>();
        newCandy.SetPool(candyItemPool);
        return newCandy;
    }

    private void OnGet(CandyItem candyItem)
    {
        candyItem.gameObject.SetActive(true);
        float randPosX = Random.Range(-GetHorizontalBounds() / 1.5f, GetHorizontalBounds() / 1.5f);
        Vector3 pos = new Vector3(randPosX, transform.position.y);
        candyItem.transform.position = pos;
        var gameCandies = battleMode.currentStage.battleCandies;
        if (gameCandies.Count <= 0) return;
        int randCandyIndex = Random.Range(0, gameCandies.Count);
        var candyElement = gameCandies.ElementAt(randCandyIndex);
        CandySO so = candySOs.FirstOrDefault((x) => x.candyType == candyElement.Key);
        gameCandies[candyElement.Key] -= 1;
        if (candyElement.Value <= 0)
        {
            gameCandies.Remove(candyElement.Key);
        }
        candyItem.updateCandyItem(new Candy()
        {
            candyType = so.candyType,
            sprite = so.candyImage
        });
    }

    private void OnRelease(CandyItem candyItem)
    {
        candyItem.gameObject.SetActive(false);
    }

    private void OnDestroyCandy(CandyItem candyItem)
    {
        Destroy(candyItem.gameObject);
    }
    private void Init()
    {

    }
    public float GetHorizontalBounds()
    {
        float hSize = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        return hSize;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print(candyItemPool.CountInactive);
            candyItemPool.Get();
        }
    }
}
