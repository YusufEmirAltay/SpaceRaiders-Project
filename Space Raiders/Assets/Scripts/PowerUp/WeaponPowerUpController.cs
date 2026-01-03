using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPowerUpController : PowerUpController
{
    [field: SerializeField]
    public Weapon Weapon { get; private set; }

    [SerializeField] 
    private float _duration = 10f;
    public override void Collect(PlayerController player)
    {
        player.ApplyWeaponPowerUp(Weapon, _duration);
        base.Collect(player);
    }
}
