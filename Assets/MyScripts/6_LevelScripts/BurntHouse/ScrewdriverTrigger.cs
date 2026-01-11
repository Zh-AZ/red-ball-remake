using System.Collections;
using TMPro;
using UnityEngine;

public class ScrewdriverTrigger : TakeThings
{
    private const string ITEM_ID = "Screwdriver";

    private void OnTriggerStay(Collider other)
    {
        //EnterTigger(hasScrewdriver, "Press E to pick up the screwdriver");
        EnterTrigger(ITEM_ID, "Press E to pick up the screwdriver");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
