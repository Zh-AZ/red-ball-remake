using System.Collections;
using TMPro;
using UnityEngine;

public class CarTrigger : PlayerInventory
{
    [SerializeField] private TMP_Text[] interactText;
    private bool isInsideTrigger;

    private void Update()
    {
        if (isInsideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(FillCanister());
        }
    }

    private void OnTriggerStay(Collider other)
    {
        isInsideTrigger = true;

        foreach (TMP_Text text in interactText)
        {
            if (HasItem("CanisterFuel"))
            {
                break;
            }
            else
            {
                text.gameObject.SetActive(true);
            }

            if (HasItem("Canister") && HasItem("Hose"))
            {
                text.text = "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы заполнить канистру бензином";
            }
            else if (HasItem("Canister"))
            {
                text.text = "Нужнен шланг чтобы слить топливо";
            }
            else if (HasItem("Hose"))
            {
                text.text = "Нужна канистра чтобы набрать бензин";
            }
            else
            {
                text.text = "Нужна канистра и шланг чтобы заполнить канистру топливом";
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isInsideTrigger = false;

        foreach (TMP_Text text in interactText)
            text.gameObject.SetActive(false);
    }


    /// <summary>
    /// Заполение канистры топливом и проверка наличия необходимых предметов
    /// </summary>
    /// <returns></returns>
    IEnumerator FillCanister()
    {
        if (HasItem("Canister") && HasItem("Hose"))
        {
            AddItem("CanisterFuel");

            foreach (TMP_Text text in interactText)
                text.text = "Вы заполнили канистру топливом";

            yield return new WaitForSeconds(3f);

            foreach (TMP_Text text in interactText)
                text.gameObject.SetActive(false);
        }
    }
}
