using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnimation : MonoBehaviour
{
    public GameObject movingBg;
    Material material;

    Vector2 offset;

    public float xVelocity, yVelocity;
    private void Awake()
    {
        material = movingBg.GetComponent<Renderer>().material;
    }

    private void Start()
    {
        offset = new Vector2(xVelocity, yVelocity);
    }
    private void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
