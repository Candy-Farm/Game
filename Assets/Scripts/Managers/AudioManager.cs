using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AudioSettings;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    List<GameObject> audioPlayerCollection;

    public AudioClip[] GameAudioClips;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void Start()
    {
        audioPlayerCollection = new List<GameObject>();
    }

    AudioSource CreateAudioSource(AudioGroup audioGroup)
    {
        bool audioExists = audioPlayerCollection.Exists((player) => player.name == audioGroup.ToString());
        if (audioExists)
        {
            AudioSource audioSource = audioPlayerCollection.Find((player) => player.name == audioGroup.ToString()).GetComponent<AudioSource>();
            return audioSource;
        }
        AudioSource audioPlayer = new GameObject(audioGroup.ToString()).AddComponent<AudioSource>();
        audioPlayerCollection.Add(audioPlayer.gameObject);
        return audioPlayer;
    }
    public void PlaySound(AudioGroup group, string clipName)
    {
        AudioSource source = CreateAudioSource(group);
        print(Array.Find(GameAudioClips, (audioClip) => audioClip.name == clipName));
        AudioClip clip = Array.Find(GameAudioClips, (audioClip) => audioClip.name == clipName);
        source.PlayOneShot(clip);
    }
}
