using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawnController : MonoBehaviour
{
    public GameObject candyPrefab;

    public float spawnInterval;

    float candyDropDuration = 5;
    public bool isSpawning;

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
        GameObject gameObject = Instantiate(candyPrefab, new Vector3(randWidth, position.y, position.z), Quaternion.identity);
    }

    public void stopSpawningCandies()
    {
        isSpawning = false;
        StopCoroutine(spawnCandies());
    }
}
