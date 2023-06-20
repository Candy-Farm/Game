using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Candies;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    float xAxis;
    void Start()
    {

    }

    void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
        print(xAxis);
        Vector3 playerPos = transform.position;
        transform.position += Vector3.right * xAxis * Time.deltaTime * moveSpeed;
    }
}
