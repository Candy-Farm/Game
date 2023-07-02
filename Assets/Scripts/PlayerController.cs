using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Candies;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    [HideInInspector]
    public int collectedNftsCount;
    int lifeLine = 4;



    [HideInInspector]
    public bool winGame;

    public bool canMove = false;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        canMove = true;
        Bounds();
    }

    void Update()
    {
        if (canMove)
        {
            if (Input.touchCount == 1)
                if (Camera.main.ScreenToViewportPoint(Input.mousePosition) != null)
                {
                    Vector3 mouseInput = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    float xPos = Mathf.Clamp(mouseInput.x, Bounds().x, Bounds().y);
                    transform.position = new Vector3(xPos, transform.position.y, 0);
                }
        }

    }

    public void LooseLife()
    {
        if (CandyCatchManager.instance.gameOver) return;
        lifeLine--;
        UiHandler.instance.updateLifeUi();
        if (lifeLine <= 0)
        {
            winGame = false;
            CandyCatchManager.instance.OnGameOver();
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
