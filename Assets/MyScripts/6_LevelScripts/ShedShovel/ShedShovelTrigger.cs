using TMPro;
using UnityEngine;

public class ShedShovelTrigger : PlayerInventory
{
    [SerializeField] private Animator rightShedDoorAnimation;
    [SerializeField] private Animator leftShedDoorAnimation;
    [SerializeField] private TMP_Text[] text;
    //[SerializeField] private GameObject trigger;

    private void Awake()
    {
        rightShedDoorAnimation = rightShedDoorAnimation.GetComponent<Animator>();
        leftShedDoorAnimation = leftShedDoorAnimation.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        foreach (var t in text)
        {
            if (HasItem("Key"))
            {
                t.text = "У вас есть ключ чтобы открыть дверь";
            }
            else if (!HasItem("Key"))
            {
                t.text = "Вам нужен ключ чтобы открыть дверь";
            }

            t.gameObject.SetActive(true);
        }

        if (HasItem("Key") && Input.GetKeyDown(KeyCode.E))
        {
            rightShedDoorAnimation.SetTrigger("ShedShovelOpenRightDoor");
            leftShedDoorAnimation.SetTrigger("ShedOpenLeftDoor");
            gameObject.SetActive(false);

            foreach (var t in text)
                t.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (var t in text)
            t.gameObject.SetActive(false);
    }
}
