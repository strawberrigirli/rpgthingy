using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem
{
    public string ItemName { get; set; }
    public string ItemDescription { get; set; }
    public int ItemID { get; set; }
    public int spellID { get; set; }

    public enum ItemTypes
    {
        ARMOR,
        WEAPON,
        POTION,
    }

    public ItemTypes itemType { get; set; }


}
