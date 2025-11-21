using UnityEngine;

public class SafeTrigger : MonoBehaviour
{
    [SerializeField] private Camera safeCamera;
    [SerializeField] private Rigidbody rigidbodyPlayer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbodyPlayer = rigidbodyPlayer.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            safeCamera.depth = 100;
            rigidbodyPlayer.linearVelocity = Vector3.zero;
            rigidbodyPlayer.angularVelocity = Vector3.zero;
        }
    }
}
