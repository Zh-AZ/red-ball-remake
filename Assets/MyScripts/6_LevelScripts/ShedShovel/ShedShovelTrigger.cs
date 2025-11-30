using UnityEngine;

public class ShedShovelTrigger : PlayerInventory
{
    [SerializeField] private Animator rightShedDoorAnimation;
    [SerializeField] private Animator leftShedDoorAnimation;

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
        if (hasKey == false)
        {
            Debug.Log("You need the key to open the shed!");
        }
        else if (hasKey && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("You have the key to open the shed!");
            rightShedDoorAnimation.SetTrigger("ShedShovelOpenRightDoor");
            leftShedDoorAnimation.SetTrigger("ShedOpenLeftDoor");
        }
    }
}
