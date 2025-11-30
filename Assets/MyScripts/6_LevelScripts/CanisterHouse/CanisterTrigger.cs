using UnityEngine;

public class CanisterTrigger : PlayerInventory
{
    [SerializeField] private GameObject canister;

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
        if (Input.GetKeyDown(KeyCode.E))
        {
            canister.SetActive(false);
            hasCanister = true;
        }
    }
}
