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
    private bool isInsideTrigger;

    private void Update()
    {
        if (isInsideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            TurnOnFlickerLight();
        }
    }
  
    private void OnTriggerStay(Collider other)
    {
        isInsideTrigger = true;

        foreach (var t in interactText)
        {
            if (HasItem("CanisterFuel") == false)
                t.text = "Вам нужна канистра с топливом чтобы запустить генератор";
            else
                t.text = "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы заправить генератор";

            t.gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// Взаимодействие с генератором и замен фейк лампочек на мерцающие 
    /// </summary>
    /// <param name="other"></param>
    private void TurnOnFlickerLight()
    {
        if (HasItem("CanisterFuel"))
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
        isInsideTrigger = false;

        foreach (var t in interactText)
            t.gameObject.SetActive(false);
    }
}