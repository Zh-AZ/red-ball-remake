using RedBallRemake.Inputs;
using UnityEngine;

/// <summary>
/// Ускорение при ходьбе по ступенькам (чтобы шарик не скатывался вниз)
/// </summary>
public class StepsAccleration : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerMovement = playerMovement.GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        playerMovement.speed = 10f;
    }

    private void OnCollisionExit(Collision collision)
    {
        playerMovement.speed = 3f;
    }
}
