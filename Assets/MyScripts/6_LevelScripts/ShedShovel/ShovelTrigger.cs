using TMPro;
using UnityEngine;

public class ShovelTrigger : TakeThings
{
    private const string ITEM_ID = "Shovel";


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EnterTrigger(ITEM_ID, "Press E to pick up the shovel");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
