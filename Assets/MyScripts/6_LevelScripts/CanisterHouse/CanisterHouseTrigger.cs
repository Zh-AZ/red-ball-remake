using TMPro;
using UnityEngine;

public class CanisterHouseTrigger : PlayerInventory
{
    [SerializeField] private TMP_Text[] interactText;
    [SerializeField] private Camera lockCamera;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject originalLock;
    [SerializeField] private GameObject fakeLock;
    [SerializeField] private Rigidbody playerRigidbody;
    private bool isInsideTrigger;

    private void Start()
    {
        playerRigidbody = playerRigidbody.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (isInsideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            LockReplace();
        }
    }

    /// <summary>
    /// Проверка инструментов для взлома замка
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerStay(Collider other)
    {
        isInsideTrigger = true;

        foreach (var t in interactText)
        {
            switch (HasItem("Screwdriver"), HasItem("Hammer"), HasItem("BurglarKeys"))
            {
                case (true, true, true):
                    t.text = "У вас есть все инструменты чтобы начать взлом замка";
                    break;
                case (true, false, false):
                    t.text = "У вас есть отвертка, нужны молоток и отмычки для взлома замка";
                    break;
                case (false, true, false):
                    t.text = "У вас есть молоток, нужны отвертка и отмычки для взлома замка";
                    break;
                case (false, false, true):
                    t.text = "У вас есть отмычки, нужны отвертка и молоток для взлома замка";
                    break;
                case (true, true, false):
                    t.text = "У вас есть отвертка и молоток, нужны отмычки для взлома замка";
                    break;
                case (true, false, true):
                    t.text = "У вас есть отвертка и отмычки, нужнен молоток для взлома замка!";
                    break;
                case (false, true, true):
                    t.text = "У вас есть молоток и отмычки, нужна отвертка для взлома замка";
                    break;
                default:
                    t.text = "Надо найти отвертку, молоток и отмычки чтобы взломать замок";
                    break;
            }

            t.gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// Заменить фейк замок на настоящий чтобы началась игра взлома замка
    /// </summary>
    private void LockReplace()
    {
        if (HasItem("Screwdriver") && HasItem("Hammer") && HasItem("BurglarKeys"))
        {
            playerRigidbody.linearVelocity = Vector3.zero;
            playerRigidbody.angularVelocity = Vector3.zero;

            gameObject.SetActive(false);
            lockCamera.gameObject.SetActive(true);
            originalLock.SetActive(true);
            fakeLock.SetActive(false);
            player.SetActive(false);

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
