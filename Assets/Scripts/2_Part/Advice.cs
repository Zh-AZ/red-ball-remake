using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Advice : MonoBehaviour
{
    [SerializeField] private GameObject[] adviceText;
    [SerializeField] private GameObject interactionText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(OrganizeTips());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interaction"))
        {
            interactionText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interaction"))
        {
            interactionText.SetActive(false);
        }
    }

    /// <summary>
    /// Подсказки игроку
    /// </summary>
    /// <returns></returns>
    private IEnumerator OrganizeTips()
    {
        for (int i = 0; i < adviceText.Length; i++)
        {
            adviceText[i].SetActive(true);
            yield return new WaitForSeconds(3);
            adviceText[i].SetActive(false);
        }
    }
}
