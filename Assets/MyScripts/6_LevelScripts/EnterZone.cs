using UnityEngine;

/// <summary>
/// Проверка входа и выхода игрока из зоны для управления туманом войны
/// </summary>
public class EnterZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Entered the Zone");
            ExitMapFog.Instance.EnterZone();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Exited the Zone");
            ExitMapFog.Instance.ExitZone();
        }
    }
}
