using TMPro;
using UnityEngine;

public class DestroyStones : PlayerInventory
{
    [SerializeField] private TMP_Text[] interactionText;

    /// <summary>
    /// Ломать камни при наличии лопаты
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            foreach (TMP_Text text in interactionText)
            {
                if (HasItem("Shovel"))
                {
                    text.gameObject.SetActive(true);
                    text.text = "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы копать";
                }
                else
                {
                    text.gameObject.SetActive(false);
                }
            }

            if (HasItem("Shovel") && Input.GetKeyDown(KeyCode.E))
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
