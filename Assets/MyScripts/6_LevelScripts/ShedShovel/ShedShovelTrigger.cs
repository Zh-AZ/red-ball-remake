using TMPro;
using UnityEngine;

public class ShedShovelTrigger : PlayerInventory
{
    [SerializeField] private Animator rightShedDoorAnimation;
    [SerializeField] private Animator leftShedDoorAnimation;
    [SerializeField] private TMP_Text[] text;

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
            t.gameObject.SetActive(true);
        
        if (hasKey == false)
        {
            foreach (var t in text)
                t.text = "You need the key to open the shed!";

        }
        else if (hasKey && Input.GetKeyDown(KeyCode.E))
        {
            foreach (var t in text)
                t.text = "You have the key to open the shed!";

            rightShedDoorAnimation.SetTrigger("ShedShovelOpenRightDoor");
            leftShedDoorAnimation.SetTrigger("ShedOpenLeftDoor");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (var t in text)
            t.gameObject.SetActive(false);
    }
}
