using TMPro;
using UnityEngine;

public class GeneratorTrigger : PlayerInventory
{
    [SerializeField] private GameObject generatorLight;
    [SerializeField] private GameObject firstLight;
    [SerializeField] private GameObject secondLight;

    [SerializeField] private GameObject generatorLampCopy;
    [SerializeField] private GameObject firstLampCopy;
    [SerializeField] private GameObject secondLampCopy;

    [SerializeField] private TMP_Text[] interactText;

    /// <summary>
    /// Взаимодействие с генератором и замен фейк лампочек на мерцающие 
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {
        foreach (var t in interactText)
        {
            if (HasItem("CanisterFuel") == false)
                t.text = "Вам нужна канистра с топливом чтобы запустить генератор";
            else
                t.text = "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы заправить генератор";

            t.gameObject.SetActive(true);
        }

        if (HasItem("CanisterFuel") && Input.GetKeyDown(KeyCode.E))
        {
            generatorLampCopy.SetActive(false);
            firstLampCopy.SetActive(false);
            secondLampCopy.SetActive(false);

            generatorLight.SetActive(true);
            firstLight.SetActive(true);
            secondLight.SetActive(true);
            AddItem("Electricity");
            gameObject.SetActive(false);

            foreach (var t in interactText)
                t.gameObject.SetActive(false);
        }   
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (var t in interactText)
            t.gameObject.SetActive(false);
    }
}