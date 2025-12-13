using TMPro;
using UnityEngine;

public class BurglarKeysTrigger : PlayerInventory
{
    [SerializeField] private GameObject burglarKeys;
    [SerializeField] private TMP_Text[] interactText;

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

        foreach (var t in interactText)
        {
            t.gameObject.SetActive(true);
            t.text = "Press E to pick up the burglar keys.";
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            hasBurglarKeys = true;
            burglarKeys.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (var t in interactText)
            t.gameObject.SetActive(false);
    }
}
