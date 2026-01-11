using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    //protected static bool hasKey = false;
    //protected static bool hasHose = false;
    //protected static bool hasElectricity = false;
    //protected static bool hasShovel = false;

    //protected static bool hasCanisterFuel = false;
    //protected static bool hasCanister = false;

    //protected static bool hasScrewdriver = false;
    //protected static bool hasHammer = false;
    //protected static bool hasBurglarKeys = false;

    protected static HashSet<string> items = new HashSet<string>();

    public static bool HasItem(string itemId)
    {
        return items.Contains(itemId);
    }

    public static void AddItem(string itemId)
    {
        items.Add(itemId);
    }
}
