using UnityEngine;

public class CandyBottomHandler : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}