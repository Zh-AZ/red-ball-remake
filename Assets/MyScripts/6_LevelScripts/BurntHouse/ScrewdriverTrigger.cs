using UnityEngine;

public class ScrewdriverTrigger : PlayerInventory
{
    [SerializeField] private GameObject screw;

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
            hasScrewdriver = true;
            screw.SetActive(false);

            Debug.Log("You have removed the screws with the screwdriver!");
        }
    }
}
