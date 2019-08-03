using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HeroBase
{
    public string CharacterClassName { get; set; }
    public string CharacterClassDescription { get; set; }
 //STATS
    public int Constitution { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }

}
