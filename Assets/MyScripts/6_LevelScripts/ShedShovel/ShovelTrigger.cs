using TMPro;
using UnityEngine;

public class ShovelTrigger : TakeThingsEffect
{
    private const string ITEM_ID = "Shovel";


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EnterTrigger(ITEM_ID, "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы взять лопату");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
