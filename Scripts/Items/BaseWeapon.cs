using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseItemStats
{

    public enum WeaponTypes
    {
        SWORD,
        AXE,
        WAND,
        STAFF,
        BOW,
        CROSSBOW
    }
    
    public WeaponTypes weaponTypes { get; set; } 

   
}
