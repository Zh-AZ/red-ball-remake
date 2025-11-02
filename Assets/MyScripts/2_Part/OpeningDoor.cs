using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningDoor : MonoBehaviour
{
    [SerializeField] private Animator openingDoors;
    [SerializeField] private bool isTransitonTo_3Level;

    // Start is called before the first frame update
    void Start()
    {
        openingDoors = openingDoors.GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && (Input.GetKeyDown(KeyCode.E)))
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
}
