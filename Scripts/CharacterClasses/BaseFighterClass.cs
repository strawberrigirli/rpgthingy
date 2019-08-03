using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseFighterClass : HeroBase
{
   public BaseFighterClass()
    {
        CharacterClassName = "Fighter";
        CharacterClassDescription = "Buff ladies and swords";
        Constitution = 15;
        Strength = 15;
        Dexterity = 12;
        Intelligence = 10;
        Wisdom = 10;
    }
}
