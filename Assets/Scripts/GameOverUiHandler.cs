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
    }

    public void ActivateWinPanel(bool activate)
    {
        AudioManager.instance.UpdateVolume(AudioGroup.BgMusic, 0.3f);
        AudioManager.instance.PlaySound(AudioGroup.Sfx, AudioClipNames.Sfx.SlideInandOut.ToString());
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
        var pos = gameOverPanel.localPosition;
        DOTween.To(() => gameOverPanel.anchoredPosition, x => gameOverPanel.anchoredPosition = x, new Vector2(0, 0), 1).OnStart(() =>
        {
            //Debug.Log("started");
            // CanvasGroup transparency = navPanel.GetComponent<CanvasGroup>();
            // if (transparency)
            // {
            //     transparency.alpha = 0;
            //     transparency.DOFade(1, 1);

            // }
        });
    }
}
