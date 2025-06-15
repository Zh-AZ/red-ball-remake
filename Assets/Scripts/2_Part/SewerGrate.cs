using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SewerGrate : MonoBehaviour
{
    [SerializeField] private Animator openSewerGrate;
    [SerializeField] private bool isTransitonTo_3Level;

    // Start is called before the first frame update
    void Start()
    {
        openSewerGrate = openSewerGrate.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && (Input.GetKeyDown(KeyCode.E)))
        {
            openSewerGrate.SetTrigger("OpenDoor");

            if (isTransitonTo_3Level)
            {
                openSewerGrate.SetTrigger("CloseDoor");
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
