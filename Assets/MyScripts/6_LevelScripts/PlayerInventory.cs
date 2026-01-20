using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    // Inventory flags for various items

    //[SerializeField] private bool hasKey;
    //[SerializeField] private bool hasHose;
    //[SerializeField] private bool hasElectricity;
    //[SerializeField] private bool hasShovel;

    //[SerializeField] private bool hasCanisterFuel;
    //[SerializeField] private bool hasCanister;

    //[SerializeField] private bool hasScrewdriver;
    //[SerializeField] private bool hasHammer;
    //[SerializeField] private bool hasBurglarKeys;

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
