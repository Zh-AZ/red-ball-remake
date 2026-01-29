using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static HashSet<string> items = new HashSet<string>();

    /// <summary>
    /// Проверка наличия предмета в инвентаре
    /// </summary>
    /// <param name="itemId"></param>
    /// <returns></returns>
    public static bool HasItem(string itemId)
    {
        return items.Contains(itemId);
    }

    /// <summary>
    /// Добавить предмет в инвентарь
    /// </summary>
    /// <param name="itemId"></param>
    public static void AddItem(string itemId)
    {
        items.Add(itemId);
    }

    /// <summary>
    /// Очистить инвентарь
    /// </summary>
    public static void ClearInventory()
    {
        items.Clear();
    }
}
