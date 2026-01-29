using TMPro;
using UnityEngine;

public class SafeTrigger : MonoBehaviour
{
    [SerializeField] private Camera safeCamera;
    [SerializeField] private TMP_Text[] interactText;
    [SerializeField] private AudioListener audioListenerFPV;
    [SerializeField] private AudioListener audioListenerTPV;
    [SerializeField] private GameObject player;
    [SerializeField] private Rigidbody rigidbodyPlayer;
    private AudioListener audioListenerSafe;
    private bool isInsideTrigger;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioListenerSafe = safeCamera.GetComponent<AudioListener>();
        rigidbodyPlayer = rigidbodyPlayer.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (isInsideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            rigidbodyPlayer.linearVelocity = Vector3.zero;
            rigidbodyPlayer.angularVelocity = Vector3.zero;
            player.SetActive(false);
            audioListenerFPV.enabled = false;
            audioListenerTPV.enabled = false;
            audioListenerSafe.enabled = true;
        }
    }

    /// <summary>
    /// Взаидействие с сейфом
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {
        isInsideTrigger = true;

        foreach (var t in interactText)
        {
            t.text = "Нажмите <color=#ff0059><align=\"center\"><b>Е</b></color> чтобы ввести код";
            t.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isInsideTrigger = false;

        foreach (var t in interactText)
            t.gameObject.SetActive(false);
    }
}
