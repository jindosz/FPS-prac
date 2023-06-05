using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    [Header("Components")]
    [SerializeField]
    private WeaponAssaultRifle weapon;

    [Header("Weapon Base")]
    [SerializeField]
    private TextMeshProUGUI textWeaponName;

    [SerializeField]
    private Image imageWeaponIcon;

    [SerializeField]
    private Sprite[] spriteWeaponTcons;

    [Header("Ammo")]
    [SerializeField]
    private TextMeshProUGUI textAmmo;

    private void Awake()
    {
        SetupWeapon();

        weapon.onAmmoEvent.AddListener(UpdateAmmoHUD);
    }

    private void SetupWeapon()
    {
        textWeaponName.text = weapon.WeaponName.ToString();
        imageWeaponIcon.sprite = spriteWeaponTcons[(int)weapon.WeaponName];
    }

    private void UpdateAmmoHUD(int currentAmmo, int maxAmmo)
    {
        textAmmo.text = $"<size=40>{currentAmmo}/</size>{maxAmmo}";
    }
}
