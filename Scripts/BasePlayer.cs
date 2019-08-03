using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    public string playerName { get; set; }
    public int playerLevel { get; set; }
    public HeroBase playerClass { get; set; }
    public int Constitution { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
}
