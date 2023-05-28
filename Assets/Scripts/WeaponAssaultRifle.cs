using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAssaultRifle : MonoBehaviour
{
    [Header("Audio Clips")]
    [SerializeField]
    private AudioClip       audioClipTakeOutWeapon;

    private AudioSource     audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        PlaySound(audioClipTakeOutWeapon);
    }

    private void PlaySound(AudioClip clip)
    {
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.Play();
    }
}
