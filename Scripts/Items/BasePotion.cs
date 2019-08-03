using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotion : BaseItemStats
{
   public enum PotionTypes
    {
        HEALTH,
        MANA,
        EXP,
        DEFENSE,
        SPECIALDEFENSE,
        STRENGTH,
        INTELLIGENCE,
        SPELL
    }

    public PotionTypes potionTypes { get; set; }

    
}
