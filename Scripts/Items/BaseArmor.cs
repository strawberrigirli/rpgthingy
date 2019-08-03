using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseArmor : BaseItemStats
{
    public enum ArmorTypes
    {
            HELMET,
            CHESTPIECE,
            CLOAK,
            RING,
            NECKLACE,
            BOOTS
    }

    public ArmorTypes armorTypes { get; set; }

    
}
