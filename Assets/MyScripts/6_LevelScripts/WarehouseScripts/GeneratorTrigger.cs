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
    //private MeshRenderer meshRenderer;

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
        foreach (var t in interactText)
            t.gameObject.SetActive(true);

        if (hasCanisterFuel == false)
        {
            foreach (var t in interactText)
                t.text = "You need a fuel canister to start the generator!";
        }
        else if (hasCanisterFuel && Input.GetKeyDown(KeyCode.E))
        {
            generatorLampCopy.SetActive(false);
            firstLampCopy.SetActive(false);
            secondLampCopy.SetActive(false);

            generatorLight.SetActive(true);
            firstLight.SetActive(true);
            secondLight.SetActive(true);
            hasElectricity = true;
            
            foreach (var t in interactText)
                t.text = "You have refueled the generator! Electricity restored!";
        }   
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (var t in interactText)
            t.gameObject.SetActive(false);
    }
}