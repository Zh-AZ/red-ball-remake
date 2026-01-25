using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenCamera : MonoBehaviour
{
    [SerializeField] private GameObject cameraVision;
    [SerializeField] private Rigidbody cameraRigidbody;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        cameraRigidbody = cameraRigidbody.GetComponent<Rigidbody>();
    }

    /// <summary>
    /// ¬ывод IP видеокамеры при столкновении с игроком
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cameraRigidbody.isKinematic = false;
            Destroy(cameraVision);
            animator.SetTrigger("Break");
        }
    }
}
