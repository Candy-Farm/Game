using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Candies;

public class Candy : MonoBehaviour
{
    public CandyType candyType;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        print("yes then");
    }
}
