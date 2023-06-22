using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Candies;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Bounds();
    }

    void Update()
    {
        if (Input.touchCount == 1)
            if (Camera.main.ScreenToViewportPoint(Input.mousePosition) != null)
            {
                Vector3 mouseInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                float xPos = Mathf.Clamp(mouseInput.x, Bounds().x, Bounds().y);
                transform.position = new Vector3(xPos, transform.position.y, 0);
            }
    }

    Vector3 Bounds()
    {

        Camera cam = Camera.main;
        // float height =cam.orthographicSize;
        float width = cam.orthographicSize * cam.aspect;
        float objWidth = gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        print((objWidth));
        return new Vector3(-width + objWidth, width - objWidth, 0);
    }
}
