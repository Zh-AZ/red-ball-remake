using UnityEngine;

public class KeyTrigger : PlayerInventory
{
    [SerializeField] private GameObject key;

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
            hasKey = true;
            key.SetActive(false);
            Debug.Log("You have picked up the key!");
        }
    }
}
