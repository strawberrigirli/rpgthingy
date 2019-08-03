using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyBase 
{
   public string enemyName;

 //BASE STATS
    public float baseHP;
    public float currentHP;

    public float baseMP;
    public float currentMP;

 //COMBAT STATS
    public int constitution;
    public int strength;
    public int dexterity;
    public int intelligence;
    public int wisdom;
}
