﻿using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource _audioSource;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        if (_audioSource.isPlaying) return;
        _audioSource.Play();
    }

    public void StopAudio()
    {
        _audioSource.Stop();
    }
}

