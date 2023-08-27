using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawnController : MonoBehaviour
{

    [SerializeField]
    GameObject candyPrefab;
    public Candy[] candyCollection;

    public Candy explosive;
    public Candy Nft;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnCandy), 2, 1);
        print(GetHorizontalBounds());

    }
    public void SpawnCandy()
    {
        float randPosX = Random.Range(-GetHorizontalBounds() / 1.5f, GetHorizontalBounds() / 1.5f);
        Vector3 pos = new Vector3(randPosX, transform.position.y);
        var candy = Instantiate(candyPrefab, pos, Quaternion.identity)
        .GetComponent<CandyItem>();
        int randIndex = Random.Range(0, candyCollection.Length);
        candy.updateCandyItem(candyCollection[randIndex]);
    }

    public float GetHorizontalBounds()
    {
        float hSize = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
        return hSize;
    }

}
