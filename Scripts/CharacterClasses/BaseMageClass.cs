using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMageClass : HeroBase
{
    public BaseMageClass()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "Be smart and do spells";
        Constitution = 10;
        Strength = 10;
        Dexterity = 12;
        Intelligence = 16;
        Wisdom = 12;
    }
}
