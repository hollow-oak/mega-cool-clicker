using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] public AudioSource musicSource;
    [SerializeField] public AudioSource singSource;

    [Header("SFX")]
    [SerializeField] public AudioSource coinSFX;
    [SerializeField] public AudioSource purchaseSFX;

    public void PlaySFX(AudioSource sfx)
    {
        sfx.Play();
    }
}
