using TMPro;
using UnityEngine;

public class HoseTrigger : TakeThings
{
    private const string ITEM_ID = "Hose";


    private void OnTriggerStay(Collider other)
    {
        EnterTrigger(ITEM_ID, "Press E to take the hose");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
