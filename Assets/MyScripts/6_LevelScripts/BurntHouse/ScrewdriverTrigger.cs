using System.Collections;
using TMPro;
using UnityEngine;

public class ScrewdriverTrigger : TakeThingsEffect
{
    private const string ITEM_ID = "Screwdriver";

    private void OnTriggerStay(Collider other)
    {
        EnterTrigger(ITEM_ID, "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы взять отвертку");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
