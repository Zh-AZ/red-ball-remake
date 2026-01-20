using System.Collections;
using TMPro;
using UnityEngine;

public class BurglarKeysTrigger : TakeThingsEffect
{
    private const string ITEM_ID = "BurglarKeys";


    private void OnTriggerStay(Collider other)
    {
        EnterTrigger(ITEM_ID, "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы взять отмычки");
    }

    private void OnTriggerExit(Collider other)
    {
        ExitTrigger();
    }
}
