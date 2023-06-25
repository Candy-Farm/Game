using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Candies;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    int lifeLine = 4;

    private void Awake()
    {
        instance = this;
    }
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

    public void LooseLife()
    {
        lifeLine--;
        UiHandler.instance.updateLifeUi();
        if (lifeLine <= 0)
        {
            print(lifeLine);
            GameManager.instance.OnGameOver();
            return;
        }
    }

    Vector3 Bounds()
    {

        Camera cam = Camera.main;
        float width = cam.orthographicSize * cam.aspect;
        float objWidth = gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        return new Vector3(-width + objWidth, width - objWidth, 0);
    }
}
