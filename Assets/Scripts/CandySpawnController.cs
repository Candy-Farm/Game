using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawnController : MonoBehaviour
{
    [SerializeField]
    GameObject candyPrefab;

    public float spawnInterval;

    public float nftInterval;

    [HideInInspector]
    public bool isSpawning;

    bool canDropBomb;

    int candyCount = 0;

    List<CandySO> spawnedCandies;
    public static CandySpawnController instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        spawnedCandies = new List<CandySO>();
        isSpawning = true;
        StartCoroutine(spawnCandy());
        StartCoroutine(spawnNft());
    }
    IEnumerator spawnCandy()
    {
        yield return new WaitForSeconds(2);
        while (isSpawning)
        {
            DropCandy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }
    IEnumerator spawnNft()
    {
        yield return new WaitForSeconds(10);
        float Interval = 120 / nftInterval;
        while (isSpawning)
        {
            DropNft();
            yield return new WaitForSeconds(Interval);
        }
    }
    void DropCandy()
    {
        Camera cam = Camera.main;
        Vector3 position = transform.position;
        float width = cam.orthographicSize * cam.aspect;
        float randWidth = Random.Range(-width + 0.5f, width - 0.5f);
        CreateCandy(new Vector3(randWidth, position.y, position.z));
    }
    void DropNft()
    {
        Camera cam = Camera.main;
        Vector3 position = transform.position;
        float width = cam.orthographicSize * cam.aspect;
        float randWidth = Random.Range(-width + 0.5f, width - 0.5f);
        CreateNft(new Vector3(randWidth, position.y, position.z));
    }
    public void stopSpawningCandies()
    {
        isSpawning = false;
        StopAllCoroutines();
    }

    void CreateCandy(Vector3 position)
    {
        CandySO[] candySoCollection = CandyCatchManager.instance.candySoCollection;
        int randIndex = Random.Range(0, candySoCollection.Length);
        CandySO candySO = candySoCollection[randIndex];


        if (candySO.candyType == CandyCatchManager.instance.currentTarget.cadnyType)
        {
            candyCount = 0;
        }
        else
        {
            candyCount++;
        }

        if (candyCount == 10)
        {
            candySO = System.Array.Find(candySoCollection, (cnd) => cnd.candyType == CandyCatchManager.instance.currentTarget.cadnyType);
            candyCount = 0;
        }
        Candy candy = Instantiate(candyPrefab, position, Quaternion.identity).GetComponent<Candy>();
        candy.updateCandyUiData(candySO.candyImage, candySO.candyType, (candySO.candyType == Candies.CandyType.Nft));
        // print("touched here");
        if (spawnInterval >= 1)
        {
            spawnInterval -= 0.3f;
            // print(spawnInterval);
        }
    }

    void CreateNft(Vector3 position)
    {
        CandySO nftItem = CandyCatchManager.instance.NftSo;
        Candy candy = Instantiate(candyPrefab, position, Quaternion.identity).GetComponent<Candy>();
        candy.updateCandyUiData(nftItem.candyImage, nftItem.candyType, (nftItem.candyType == Candies.CandyType.Nft));
    }
}
