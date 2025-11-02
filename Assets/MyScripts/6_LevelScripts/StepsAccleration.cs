using RedBallRemake.Inputs;
using UnityEngine;

public class StepsAccleration : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovement = playerMovement.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        playerMovement.speed = 10f;
    }

    private void OnCollisionExit(Collision collision)
    {
        playerMovement.speed = 3f;
    }
}
