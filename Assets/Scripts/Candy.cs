using UnityEngine;
using Candies;

public class Candy : MonoBehaviour
{
    CandyType candyType;
    SpriteRenderer candyImage;

    bool isNFT;

    private void Awake()
    {
        candyImage = GetComponent<SpriteRenderer>();
    }

    public void updateCandyUiData(Sprite candyImage, CandyType candyType, bool isNFT = false)
    {
        this.candyImage.sprite = candyImage;
        this.candyType = candyType;
        this.isNFT = isNFT;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            OnCandyCatch();
        }

        if (other.gameObject.tag == "Boundry")
        {
            OnCandyMissed();
        }
    }

    void OnCandyMissed()
    {
        if (candyType != CandyType.Bomb && candyType != CandyType.Nft)
        {
            PlayerController.instance.LooseLife();
        }
        Destroy(gameObject, 0.02f);
    }

    void OnCandyCatch()
    {
        if (candyType is CandyType.Bomb)
        {
            PlayerController.instance.LooseLife();
        }
        if (candyType is CandyType.Nft)
        {

        }

        Destroy(gameObject, 0.02f);
    }
}
