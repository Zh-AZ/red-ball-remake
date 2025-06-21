using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectState : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidBodytoToggle;
    [SerializeField] private bool isDisappeared;

    // Start is called before the first frame update
    void Start()
    {
        rigidBodytoToggle = rigidBodytoToggle.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && isDisappeared)
        {
            gameObject.SetActive(false);
        }
        else
        {
            rigidBodytoToggle.isKinematic = false;
        }
    }
}
