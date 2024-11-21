using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCoin : MonoBehaviour
{
    [SerializeField]
    public AudioClip[] coinAudioSource;

    [SerializeField]
    private AudioSource coinAudioDestination;

    public void PlaySound(AudioClip audioClip, float volume = 1)
    {
        coinAudioDestination.PlayOneShot(audioClip, volume);            // Отдельный класс для управлением звуками.
    }
}
