using UnityEngine;

public class SpeedLimiter : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private float speedLimit = 4f;
    private float speed;
    private bool isColliding;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRigidbody = playerRigidbody.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = playerRigidbody.linearVelocity.magnitude;
    }

    private void FixedUpdate()
    {
        if (speed > speedLimit)
        {
            playerRigidbody.linearVelocity = playerRigidbody.linearVelocity.normalized * speedLimit;
        }
        //if (speed > speedLimit && isColliding)
        //{
        //    playerRigidbody.linearVelocity = playerRigidbody.linearVelocity.normalized * speedLimit;
        //}
    }

    //private void OnCollisionStay(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        isColliding = true;
    //    }
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        isColliding = false;
    //    }
    //}
}
