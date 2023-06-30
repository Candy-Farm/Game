using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawnController : MonoBehaviour
{
    [SerializeField]
    GameObject candyPrefab;
    public float spawnInterval;

    [HideInInspector]
    public bool isSpawning;

    bool canDropBomb;
    bool canDropNft;

    public static CandySpawnController instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        isSpawning = true;
        StartCoroutine(spawnCandies());
    }
    IEnumerator spawnCandies()
    {
        yield return new WaitForSeconds(2);
        while (isSpawning)
        {
            DropCandy();
            yield return new WaitForSeconds(spawnInterval);
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

    public void stopSpawningCandies()
    {
        isSpawning = false;
        StopCoroutine(spawnCandies());
    }

    void CreateCandy(Vector3 position)
    {
        CandySO[] candySoCollection = GameManager.instance.candySoCollection;
        int randIndex = Random.Range(0, candySoCollection.Length);
        CandySO candySO = candySoCollection[randIndex];
        Candy candy = Instantiate(candyPrefab, position, Quaternion.identity).GetComponent<Candy>();
        candy.updateCandyUiData(candySO.candyImage, candySO.candyType, (candySO.candyType == Candies.CandyType.Nft));

    }
}
