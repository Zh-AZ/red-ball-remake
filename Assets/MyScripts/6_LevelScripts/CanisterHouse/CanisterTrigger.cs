using TMPro;
using UnityEngine;

public class CanisterTrigger : TakeThingsEffect
{
    private const string ITEM_ID = "Canister";


    private void OnTriggerStay(Collider other)
    {
        EnterTrigger(ITEM_ID, "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы взять канистру");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
