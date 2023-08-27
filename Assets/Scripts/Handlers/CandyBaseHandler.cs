using UnityEngine;

public class CandyBaseHandler : MonoBehaviour
{
    // private void OnCollisionEnter2D(Collision2D collider)
    // {
    //     Destroy(collider.gameObject);
    // }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}