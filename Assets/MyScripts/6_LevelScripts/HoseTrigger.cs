using UnityEngine;

public class HoseTrigger : PlayerInventory
{
    [SerializeField] private GameObject hose;

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
            hasHose = true;
            hose.SetActive(false);
            Debug.Log("You have taken the hose!");
        }
    }
}
