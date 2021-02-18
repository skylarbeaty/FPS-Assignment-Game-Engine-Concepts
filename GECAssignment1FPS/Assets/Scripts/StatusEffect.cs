using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffect : MonoBehaviour
{
    bool instantCooldown = false;

    float instantCooldownEnd;

    public bool canInstantCooldown{get{return !instantCooldown;}}
    void Update()
    {
        if (instantCooldown && Time.time > instantCooldownEnd)//instant cooldown timer
            EndInstantCooldown();
    }

    public void StartInstantCooldown(float timing){
        instantCooldown = true;
        instantCooldownEnd = Time.time + timing;
        WeaponController.cooldownPowerup = true;//activate on modified microgame file
    }
    void EndInstantCooldown(){
        instantCooldown = false;
        WeaponController.cooldownPowerup = false;
    }
}
