using UnityEngine;

public class WarehouseTrigger : PlayerInventory
{
    [SerializeField] private Animator warehouseDoorAnimation; 

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
        if (hasElectricity == false)
        {
            Debug.Log("You need to restore electricity to open the warehouse!");
        }
        else if (hasElectricity && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("You have restored electricity to open the warehouse!");
            warehouseDoorAnimation.SetTrigger("WarehouseOpenDoor");
        }
    }
}
