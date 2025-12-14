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
            if (hasKey)
            {
                t.text = "You have the key to open the shed!";
            }
            else if (!hasKey)
            {
                t.text = "You need the key to open the shed!";
            }

            t.gameObject.SetActive(true);
        }

        if (hasKey && Input.GetKeyDown(KeyCode.E))
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
