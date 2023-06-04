using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAssaultRifle : MonoBehaviour
{
    [Header("Audio Clips")]
    [SerializeField]
    private AudioClip       audioClipTakeOutWeapon;

    [Header("Weapon Setting")]
    [SerializeField]
    private WeaponSetting   weaponSetting;

    private float           lastAttackTime = 0;

    private AudioSource                 audioSource;
    private PlayerAnimatorController    animator;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        animator    = GetComponentInParent<PlayerAnimatorController>();
    }

    private void OnEnable()
    {
        PlaySound(audioClipTakeOutWeapon);
    }

    public void StartWeaponAction(int type=0)
    {
        if ( type == 0 )
        {
            if ( weaponSetting.isAutomaticAttack == true )
            {
                StartCoroutine("OnAttackLoop");
            }

            else
            {
                OnAttack();
            }
        }
    }

    public void StopWeaponAction(int type=0)
    {
        if ( type == 0 )
        {
            StopCoroutine("OnAttackLoop");
        }
    }

    private IEnumerator OnAttackLoop()
    {
        while ( true )
        {
            OnAttack();

            yield return null;
        }
    }

    public void OnAttack()
    {
        if ( Time.time - lastAttackTime > weaponSetting.attackRate )
        {
            if ( animator.MoveSpeed > 0.5f )
            {
                return;
            }
        }

        lastAttackTime = Time.time;

        animator.Play("Fire", -1, 0);  //자동 공격 애니메이션 이상함 <-- 고치기 + 사운드부터
    }

    private void PlaySound(AudioClip clip)
    {
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.Play();
    }
}
