using System.Collections;
using TMPro;
using UnityEngine;

public class BurglarKeysTrigger : TakeThings
{
    private const string ITEM_ID = "BurglarKeys";


    private void OnTriggerStay(Collider other)
    {
        EnterTrigger(ITEM_ID, "Press E to pick up the burglar keys");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
