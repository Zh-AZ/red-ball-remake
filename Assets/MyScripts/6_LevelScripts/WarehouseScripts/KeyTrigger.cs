using TMPro;
using UnityEngine;

public class KeyTrigger : TakeThingsEffect
{
    private const string ITEM_ID = "Key";


    private void OnTriggerStay(Collider other)
    {
        EnterTrigger(ITEM_ID, "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы взять ключ");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
