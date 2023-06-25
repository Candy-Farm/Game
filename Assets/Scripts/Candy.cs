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
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0.02f);
        }

        if (other.gameObject.tag == "Boundry")
        {
            PlayerController.instance.LooseLife();
            Destroy(gameObject, 0.02f);
        }
    }




}
