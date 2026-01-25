using System.Collections;
using TMPro;
using UnityEngine;

public class HammerTrigger : TakeThingsEffect
{
    private const string ITEM_ID = "Hammer";

    private void OnTriggerStay(Collider other)
    {
        EnterTrigger(ITEM_ID, "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы взять молоток");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
