using TMPro;
using UnityEngine;

public class WarehouseTrigger : PlayerInventory
{
    [SerializeField] private Animator warehouseDoorAnimation;
    [SerializeField] private TMP_Text[] text;
    private bool isInsideTrigger;


    private void Awake()
    {
        warehouseDoorAnimation = warehouseDoorAnimation.GetComponent<Animator>();
    }

    private void Update()
    {
        if (isInsideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            OpenWarehouseDoors();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        isInsideTrigger = true;

        foreach (var t in text)
        {
            if (HasItem("Electricity") == false)
                t.text = "Нужно электричество чтобы открыть дверь";
            else if (HasItem("Electricity"))
                t.text = "Електричество подключено, можно открыть дверь";

            t.gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// Взаимодействие с дверью склада
    /// </summary>
    /// <param name="other"></param>
    private void OpenWarehouseDoors()
    {
        if (HasItem("Electricity"))
        {
            warehouseDoorAnimation.SetTrigger("WarehouseOpenDoor");
            gameObject.SetActive(false);

            foreach (var t in text)
                t.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isInsideTrigger = false;

        foreach (var t in text)
            t.gameObject.SetActive(false);
    }
}
