using System.Collections;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    [SerializeField] private Light generatorFickeringLight;
    [SerializeField] private Light secondFlickeringLight;
    //[SerializeField] private Light thirdFlickeringLight;
    [SerializeField] private Renderer generatorLamp;
    [SerializeField] private Renderer firstLamp;
    //[SerializeField] private Renderer secondLamp;
    [SerializeField] private Material emissionMaterial;
    [SerializeField] private Material offMaterial;

    private void Awake()
    {
        generatorLamp = generatorLamp.GetComponent<Renderer>();
        firstLamp = firstLamp.GetComponent<Renderer>();
        //secondLamp = secondLamp.GetComponent<Renderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(FlickerLight());
    }

    // Update is called once per frame
    void Update()
    {

    }
 
    private IEnumerator FlickerLight()
    {
        while (true)
        {
            generatorFickeringLight.enabled = !generatorFickeringLight.enabled;
            secondFlickeringLight.enabled = !secondFlickeringLight.enabled;
            //thirdFlickeringLight.enabled = !thirdFlickeringLight.enabled;

            if (generatorFickeringLight.enabled)
            {
                Material[] emissionMaterials = generatorLamp.materials;
                emissionMaterials[1] = emissionMaterial;
                generatorLamp.materials = emissionMaterials;
                firstLamp.material = emissionMaterial;
                //secondLamp.material = emissionMaterial;
            }
            else
            {
                Material[] offMaterials = generatorLamp.materials;
                offMaterials[1] = offMaterial;
                generatorLamp.materials = offMaterials;
                firstLamp.material = offMaterial;
                //secondLamp.material = offMaterial;
            }

            yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));

            //if (generatorTrigger.clickLight)
            //{
            //    generatorFickeringLight.enabled = !generatorFickeringLight.enabled;
            //    secondFlickeringLight.enabled = !secondFlickeringLight.enabled;
            //    thirdFlickeringLight.enabled = !thirdFlickeringLight.enabled;
            //    yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));
            //}
        }
    }
}
