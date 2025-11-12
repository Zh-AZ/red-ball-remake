using UnityEngine;

public class GeneratorTrigger : PlayerInventory
{
    [SerializeField] private Renderer generatorLamp;
    [SerializeField] private Renderer firstLamp;
    [SerializeField] private Renderer secondLamp;
    [SerializeField] private Material emissionMaterial;
    //private MeshRenderer meshRenderer;

    private void Awake()
    {
        generatorLamp = generatorLamp.GetComponent<Renderer>();
        firstLamp = firstLamp.GetComponent<Renderer>();
        secondLamp = secondLamp.GetComponent<Renderer>();
    }

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
        if (this.hasCanisterFuel == false)
        {
            Debug.Log("You need a fuel canister to start the generator!");
        }
        else if (this.hasCanisterFuel == true && Input.GetKeyDown(KeyCode.E))
        {
            Material[] materials = generatorLamp.materials;
            materials[1] = emissionMaterial;
            generatorLamp.materials = materials;
            //generatorLamp.materials[0] = emissionMaterial;
            firstLamp.material = emissionMaterial;
            secondLamp.material = emissionMaterial;
            Debug.Log("You have refueled the generator! Electricity restored.");
        }   
    }
}