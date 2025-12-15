using TMPro;
using UnityEngine;

public class HammerTrigger : PlayerInventory
{
    [SerializeField] private GameObject hammer;
    [SerializeField] private TMP_Text[] interactionText;

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
        foreach (TMP_Text text in interactionText)
        {
            if (hasHammer)
            {
                text.gameObject.SetActive(false);
            }
            else
            {
                text.gameObject.SetActive(true);
            }
            
            text.text = "Press E to pick up the hammer";
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            hasHammer = true;
            hammer.SetActive(false);
        
            foreach (TMP_Text text in interactionText)
                text.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (TMP_Text text in interactionText)
            text.gameObject.SetActive(false);
    }
}
