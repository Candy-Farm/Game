using System.Collections;
using System.Collections.Generic;
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

    public static GameOverUiHandler instance;

    private void Awake()
    {
        instance = this;
        AnimateGameOverPanel();
    }

    public void ActivateWinPanel(bool activate)
    {
        AudioManager.instance.UpdateVolume(AudioGroup.BgMusic, 0.3f);
        AudioManager.instance.PlayAmbience(true);
        nftCountTextUi.text = PlayerController.instance.collectedNftsCount.ToString();
        rewardsContainer.SetActive(activate);
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
    private void AnimateGameOverPanel()
    {
        var gameOverPanel = GetComponent<RectTransform>();
        float posY = gameOverPanel.anchoredPosition.y;
        print(posY);
        gameOverPanel.anchoredPosition = new Vector2(gameOverPanel.anchoredPosition.x, gameOverPanel.anchoredPosition.y - 100);
        gameOverPanel.DOAnchorPosY(posY, 5);
        AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.SlideInandOut.ToString());
        // DOTween.To(() => gameOverPanel., y => gameOverPanel.localPosition = y, new Vector3(pos.x, pos.y, 0), 0.5f).OnStart(() =>
        // {
        //     // gameOverPanel.transform.localPosition =
        //     AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.SlideInandOut.ToString());
        // });
    }
}
