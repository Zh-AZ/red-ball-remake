using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningDoor : MonoBehaviour
{
    [SerializeField] private Animator openingDoors;
    [SerializeField] private bool isTransitonTo_3Level;
    protected bool isInsisdeTrigger;
    private string objectName;

    // Start is called before the first frame update
    void Start()
    {
        openingDoors = openingDoors.GetComponent<Animator>();
    }

    private void Update()
    {
        if (isInsisdeTrigger && (Input.GetKeyDown(KeyCode.E)))
        {
            OpenDoors(objectName);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        objectName = other.gameObject.tag;
        isInsisdeTrigger = true;
    }

    private void OpenDoors(string objectName)
    {
        if (objectName == "Player")
        {
            openingDoors.SetTrigger("OpenDoor");

            if (isTransitonTo_3Level)
            {
                openingDoors.SetTrigger("CloseDoor");
                StartCoroutine(WaitTime());
            }
        }
    }

    private IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(3);
    }

    private void OnTriggerExit(Collider other)
    {
        isInsisdeTrigger = false;
    }
}
