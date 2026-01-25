using TMPro;
using UnityEngine;

public class SafeTrigger : MonoBehaviour
{
    [SerializeField] private Camera safeCamera;
    [SerializeField] private Rigidbody rigidbodyPlayer;
    [SerializeField] private TMP_Text[] interactText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbodyPlayer = rigidbodyPlayer.GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Взаидействие с сейфом
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {
        foreach (var t in interactText)
        {
            t.text = "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы ввести код";
            t.gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            safeCamera.depth = 100;
            rigidbodyPlayer.linearVelocity = Vector3.zero;
            rigidbodyPlayer.angularVelocity = Vector3.zero;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (var t in interactText)
            t.gameObject.SetActive(false);
    }
}
