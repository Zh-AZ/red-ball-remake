using UnityEngine;

public class ShovelTrigger : PlayerInventory
{
    [SerializeField] private GameObject shovel;

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
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            hasShovel = true;
            shovel.SetActive(false);
            Debug.Log("You have picked up the shovel!");
        }
    }
}
