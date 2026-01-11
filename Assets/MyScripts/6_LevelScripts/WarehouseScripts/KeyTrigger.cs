using TMPro;
using UnityEngine;

public class KeyTrigger : TakeThings
{
    private const string ITEM_ID = "Key";


    private void OnTriggerStay(Collider other)
    {
        EnterTrigger(ITEM_ID, "Press E to pick up the key");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
