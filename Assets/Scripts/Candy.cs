using UnityEngine;
using Candies;
using AudioSettings;

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
        if (CandyCatchManager.instance.gameOver == true)
        {
            Destroy(gameObject, 0.02f);
            return;
        }
        if (candyType is CandyType.Bomb)
        {
            AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.WrongCandy.ToString());
            PlayerController.instance.LooseLife();
        }
        else if (candyType is CandyType.Nft)
        {
            PlayerController.instance.collectedNftsCount++;
            AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.CandyCatch.ToString());
        }
        else
        {
            AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.CandyCatch.ToString());

        }

        Target currentTarget = CandyCatchManager.instance.currentTarget;
        if (currentTarget.cadnyType == candyType)
        {
            if (currentTarget.updateTarget())
            {
                PlayerController.instance.winGame = true;
                CandyCatchManager.instance.OnGameOver();
            };
            UiHandler.instance.updateTargetUi(currentTarget);
        }

        Destroy(gameObject, 0.02f);
    }
}
