using UnityEngine;

/// <summary>
/// ограничение скорости игрока
/// </summary>
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
    }
}
