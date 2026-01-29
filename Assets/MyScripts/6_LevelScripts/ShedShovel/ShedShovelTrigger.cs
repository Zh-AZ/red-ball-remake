using TMPro;
using UnityEngine;

public class ShedShovelTrigger : PlayerInventory
{
    [SerializeField] private Animator rightShedDoorAnimation;
    [SerializeField] private Animator leftShedDoorAnimation;
    [SerializeField] private TMP_Text[] interactTexts;
    private bool isInsideTrigger;


    private void Awake()
    {
        rightShedDoorAnimation = rightShedDoorAnimation.GetComponent<Animator>();
        leftShedDoorAnimation = leftShedDoorAnimation.GetComponent<Animator>();
    }

    private void Update()
    {
        if (isInsideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            OpenDoors();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        isInsideTrigger = true;

        foreach (var t in interactTexts)
        {
            if (HasItem("Key"))
            {
                t.text = "У вас есть ключ чтобы открыть дверь";
            }
            else if (HasItem("Key") == false)
            {
                t.text = "Вам нужен ключ чтобы открыть дверь";
            }

            t.gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// Открытие двери сарая с лопатой
    /// </summary>
    /// <param name="other"></param>
    private void OpenDoors()
    {
        if (HasItem("Key"))
        {
            rightShedDoorAnimation.SetTrigger("ShedShovelOpenRightDoor");
            leftShedDoorAnimation.SetTrigger("ShedOpenLeftDoor");
            gameObject.SetActive(false);

            foreach (var t in interactTexts)
                t.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isInsideTrigger = false;
        foreach (var t in interactTexts)
            t.gameObject.SetActive(false);
    }
}
