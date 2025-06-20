using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.tag = "HiddenPlayer";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("HiddenPlayer"))
        {
            other.gameObject.tag = "Player";
        }
    }
}
