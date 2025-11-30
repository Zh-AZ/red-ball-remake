using UnityEngine;

public class HammerTrigger : PlayerInventory
{
    [SerializeField] private GameObject hammer;

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
            hasHammer = true;
            hammer.SetActive(false);
            Debug.Log("You have picked up the hammer!");
        }
    }
}
