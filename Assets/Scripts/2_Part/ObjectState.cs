using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectState : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidBodytoToggle;
    [SerializeField] private GameObject fallingSwing;
    [SerializeField] private GameObject gameObjectToDestroy;
    [SerializeField] private bool isDisappeared;
    [SerializeField] private bool canFallObject;

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
        if (gameObjectToDestroy != null)
        {
            Destroy(gameObjectToDestroy);
        }

        if (collision.gameObject.CompareTag("Player") && isDisappeared)
        {
            gameObject.SetActive(false);
       
        }
        else if (collision.gameObject.CompareTag("Player") && canFallObject)
        {
            if (fallingSwing.GetComponent<HingeJoint>() == null)
            {
                rigidBodytoToggle.isKinematic = false;
            }
            else
            {
                Destroy(fallingSwing.GetComponent<HingeJoint>());
            }
        }
        else 
        {
            rigidBodytoToggle.isKinematic = false;
        }
    }
}
