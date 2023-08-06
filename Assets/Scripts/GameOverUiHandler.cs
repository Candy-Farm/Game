using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using AudioSettings;
using DG.Tweening;
public class GameOverUiHandler : MonoBehaviour
{

    [SerializeField]
    GameObject rewardsContainer;

    [SerializeField]
    TextMeshProUGUI nftCountTextUi;

    [SerializeField]
    TextMeshProUGUI winText;

    public static GameOverUiHandler instance;

    private void Awake()
    {
        instance = this;
        //AnimateGameOverPanel();
    }

    public void ActivateWinPanel(bool activate)
    {
        AudioManager.instance.UpdateVolume(AudioGroup.BgMusic, 0.3f);
        AudioManager.instance.PlayAmbience(true);
        nftCountTextUi.text = PlayerController.instance.collectedNftsCount.ToString();
        rewardsContainer.SetActive(activate);
        // if()
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToMenu()
    {
        AudioManager.instance.StopAudio(AudioGroup.BgMusic);
        SceneManager.LoadScene("Menu");
    }
    public void AnimateGameOverPanel()
    {
        gameObject.SetActive(true);
        ActivateWinPanel(PlayerController.instance.winGame);
        var gameOverPanel = GetComponent<RectTransform>();
        float posY = gameOverPanel.anchoredPosition.y;
        print(posY);
        print(new Vector2(gameOverPanel.anchoredPosition.x, gameOverPanel.anchoredPosition.y - gameOverPanel.rect.height));
        gameOverPanel.anchoredPosition = new Vector2(gameOverPanel.anchoredPosition.x, gameOverPanel.anchoredPosition.y - gameOverPanel.rect.height);
        gameOverPanel.DOAnchorPosY(posY, 0.5f);
        AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.SlideInandOut.ToString());
        updateWinText(PlayerController.instance.winGame, GetWinText());
    }

    private TextMeshProUGUI GetWinText()
    {
        return winText;
    }

    void updateWinText(bool win, TextMeshProUGUI winText)
    {
        winText.gameObject.SetActive(true);
        if (win)
        {
            // winText.color = Col;
            winText.text = "You Win";
        }
        else
        {
            // winText.color = Color.red;
            winText.text = "You Loss";
        }
    }
}
