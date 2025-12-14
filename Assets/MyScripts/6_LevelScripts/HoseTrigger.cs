using TMPro;
using UnityEngine;

public class HoseTrigger : PlayerInventory
{
    [SerializeField] private GameObject hose;
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
            if (hasHose)
            {
                text.gameObject.SetActive(false);
            }
            else
            {
                text.gameObject.SetActive(true);
            }
            
            text.text = "Press E to take the hose";
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            hasHose = true;
            hose.SetActive(false);

            foreach (TMP_Text text in interactText)
                text.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (TMP_Text text in interactText)
            text.gameObject.SetActive(false);
    }
}
