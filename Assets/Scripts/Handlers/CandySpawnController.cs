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
        InvokeRepeating(nameof(createCandy), 2, 1);

    }
    public void createCandy()
    {
        var candy = Instantiate(candyPrefab, transform.position, Quaternion.identity);
    }


    public void onCandyDropped(GameObject candy)
    {
        Destroy(candy);
    }
}
