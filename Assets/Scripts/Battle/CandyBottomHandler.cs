using UnityEngine;

public class CandyBottomHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.activeSelf == false)
            FindFirstObjectByType<CandySpawnController>().candyItemPool.Release(collider.GetComponent<CandyItem>());
    }
}