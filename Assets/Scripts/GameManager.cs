using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] candyPrefabs;
    public GameObject explosivePrefab;
    public GameObject spawningPoint;

    public float spawnInterval;

    float candyDropDuration = 5;
    public bool stopSpawning = false;

    void Start()
    {
        StartCoroutine(spawnCandies());
    }

    private void Update()
    {

    }

    IEnumerator spawnCandies()
    {
        yield return new WaitForSeconds(2);
        while (!stopSpawning)
        {
            DropCandy();
            // if (candyDropDuration == 500)
            // {
            //     candyDropDuration = 0;
            // }
            // else
            // {
            //     if (spawnInterval > 0.5)
            //     {
            //         spawnInterval -= 0.2f;
            //     }
            //     candyDropDuration += Time.deltaTime;
            // }
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void DropCandy()
    {
        Camera cam = Camera.main;
        int randIndex = Random.Range(0, candyPrefabs.Length);
        Vector3 position = spawningPoint.gameObject.transform.position;
        float width = cam.orthographicSize * cam.aspect;
        float randWidth = Random.Range(-width + 0.5f, width - 0.5f);
        GameObject gameObject = Instantiate(candyPrefabs[randIndex], new Vector3(randWidth, position.y, position.z), Quaternion.identity);

    }
}
