using UnityEngine;

public class BurglarKeysTrigger : PlayerInventory
{
    [SerializeField] private GameObject burglarKeys;

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
            hasBurglarKeys = true;
            burglarKeys.SetActive(false);
            Debug.Log("You have picked up the burglar keys!");
        }
    }
}
