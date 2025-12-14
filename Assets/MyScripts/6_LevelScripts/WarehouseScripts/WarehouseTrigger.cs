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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        foreach (var t in text)
        {
            if (hasElectricity == false)
                t.text = "You need to restore electricity to open the warehouse!";
            else if (hasElectricity)
                t.text = "You have the electricity to open the warehouse!";

            t.gameObject.SetActive(true);
        }

        if (hasElectricity && Input.GetKeyDown(KeyCode.E))
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
