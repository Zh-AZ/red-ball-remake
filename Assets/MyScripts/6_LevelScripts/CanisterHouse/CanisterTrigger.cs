using TMPro;
using UnityEngine;

public class CanisterTrigger : TakeThings
{
    private const string ITEM_ID = "Canister";


    private void OnTriggerStay(Collider other)
    {
        EnterTrigger(ITEM_ID, "Press E to take the canister");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
