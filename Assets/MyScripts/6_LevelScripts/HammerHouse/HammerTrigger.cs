using System.Collections;
using TMPro;
using UnityEngine;

public class HammerTrigger : TakeThings
{
    private const string ITEM_ID = "Hammer";


    private void OnTriggerStay(Collider other)
    {
        EnterTrigger(ITEM_ID, "Press E to pick up the hammer");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
