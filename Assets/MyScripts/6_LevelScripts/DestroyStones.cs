using TMPro;
using UnityEngine;

public class DestroyStones : PlayerInventory
{
    [SerializeField] private TMP_Text[] interactionText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            foreach (TMP_Text text in interactionText)
            {
                if (hasShovel)
                {
                    text.gameObject.SetActive(true);
                    text.text = "Press E to destroy the stones";
                }
                else
                {
                    text.gameObject.SetActive(false);
                }
            }

            if (hasShovel && Input.GetKeyDown(KeyCode.E))
            {
                Destroy(gameObject);

                foreach (TMP_Text text in interactionText)
                    text.gameObject.SetActive(false);
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        foreach (TMP_Text text in interactionText)
            text.gameObject.SetActive(false);
    }
}
