using TMPro;
using UnityEngine;

public class ShovelTrigger : PlayerInventory
{
    [SerializeField] private GameObject shovel;
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
        if (other.CompareTag("Player"))
        {
            foreach (TMP_Text text in interactText)
            {
                if (hasShovel)
                {
                    text.gameObject.SetActive(false);
                }
                else
                {
                    text.gameObject.SetActive(true);
                }

                text.text = "Press E to pick up the shovel";
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                hasShovel = true;
                shovel.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (TMP_Text text in interactText)
            text.gameObject.SetActive(false);
    }
}
