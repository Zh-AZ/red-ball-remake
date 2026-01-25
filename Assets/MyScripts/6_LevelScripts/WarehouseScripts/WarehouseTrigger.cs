using TMPro;
using UnityEngine;

public class WarehouseTrigger : PlayerInventory
{
    [SerializeField] private Animator warehouseDoorAnimation;
    [SerializeField] private TMP_Text[] text;

    private void Awake()
    {
        warehouseDoorAnimation = warehouseDoorAnimation.GetComponent<Animator>();
    }

    /// <summary>
    /// Взаимодействие с дверью склада
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {
        foreach (var t in text)
        {
            if (HasItem("Electricity") == false)
                t.text = "Нужно электричество чтобы открыть дверь";
            else if (HasItem("Electricity"))
                t.text = "Електричество подключено, можно открыть дверь";

            t.gameObject.SetActive(true);
        }

        if (HasItem("Electricity") && Input.GetKeyDown(KeyCode.E))
        {
            warehouseDoorAnimation.SetTrigger("WarehouseOpenDoor");
            gameObject.SetActive(false);

            foreach (var t in text)
                t.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (var t in text)
            t.gameObject.SetActive(false);
    }
}
