using TMPro;
using UnityEngine;

public class HoseTrigger : TakeThingsEffect
{
    private const string ITEM_ID = "Hose";


    private void OnTriggerStay(Collider other)
    {
        EnterTrigger(ITEM_ID, "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы взять шланг");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
