using UnityEngine;

public class CarTrigger : PlayerInventory
{
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
        if (hasCanister && hasHose && Input.GetKeyDown(KeyCode.E))
        {
            hasCanisterFuel = true;
            Debug.Log("You have refueled the car!");
        }
    }
}
