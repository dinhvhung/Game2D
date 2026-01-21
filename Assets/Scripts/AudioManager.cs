using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource backgroundAudioSource;
    [SerializeField] private AudioSource effectAudioSource;
    
    [SerializeField] private AudioClip backGroundClip;
    [SerializeField] private AudioClip coinClip;
    [SerializeField] private AudioClip jumpClip;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayBackgroundMusic();
    }

    public void PlayBackgroundMusic() {
        backgroundAudioSource.clip = backGroundClip;
        backgroundAudioSource.Play();
    }

    public void PlayCoinSound() {
        effectAudioSource.PlayOneShot(coinClip);
    }

    public void PlayJumpSound() {
        effectAudioSource.PlayOneShot(jumpClip);
    }
}
