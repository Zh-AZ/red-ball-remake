using UnityEngine;

public class DestroyLattice : MonoBehaviour
{
    private Rigidbody latticeRigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        latticeRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if ( collision.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            latticeRigidbody.isKinematic = false;
        }
    }
}
