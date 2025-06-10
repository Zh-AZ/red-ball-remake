using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SewerGrate : MonoBehaviour
{
    [SerializeField] private Animator openSewerGrate;

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
        }
    }
}
