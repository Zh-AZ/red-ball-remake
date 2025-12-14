using TMPro;
using UnityEngine;

public class KeyTrigger : PlayerInventory
{
    [SerializeField] private GameObject key;
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
        foreach (TMP_Text text in interactText)
        {
            if (hasKey)
            {
                text.gameObject.SetActive(false);
            }
            else
            {
                text.gameObject.SetActive(true);
            }
            
            text.text = "Press E to pick up the key";
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            hasKey = true;
            key.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (TMP_Text text in interactText)
            text.gameObject.SetActive(false);
    }
}
