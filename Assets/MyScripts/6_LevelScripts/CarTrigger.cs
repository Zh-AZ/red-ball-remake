using System.Collections;
using TMPro;
using UnityEngine;

public class CarTrigger : PlayerInventory
{
    [SerializeField] private TMP_Text[] interactText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        //foreach (TMP_Text text in interactText)
        //{
        //    if (HasItem("CanisterFuel"))
        //    {
        //        text.gameObject.SetActive(false);
        //    }
        //    else
        //    {
        //        text.gameObject.SetActive(true);
        //    }
            
        //    if (HasItem("Canister") && HasItem("Hose"))
        //    {
        //        text.text = "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы заполнить канистру бензином";
        //    }
        //    else if (HasItem("Canister"))
        //    {
        //        text.text = "Нужнен шланг чтобы слить топливо";
        //    }
        //    else if (HasItem("Hose"))
        //    {
        //        text.text = "Нужна канистра чтобы набрать бензин";
        //    }
        //    else
        //    {
        //        text.text = "Нужна канистра и шланг чтобы заполнить канистру топливом";
        //    }
        //}

        //if (HasItem("Canister") && HasItem("Hose") && Input.GetKeyDown(KeyCode.E))
        //{
        //    AddItem("CanisterFuel");
        //    //hasCanisterFuel = true;
        //}

        StartCoroutine(FillCanister());
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (TMP_Text text in interactText)
            text.gameObject.SetActive(false);
    }

    IEnumerator FillCanister()
    {
        foreach (TMP_Text text in interactText)
        {
            if (HasItem("CanisterFuel"))
            {
                break;
                //text.gameObject.SetActive(false);
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

        if (HasItem("Canister") && HasItem("Hose") && Input.GetKeyDown(KeyCode.E))
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
