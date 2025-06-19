using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapsingBoards : MonoBehaviour
{
    private Rigidbody board;

    private void Awake()
    {
        board = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        board.isKinematic = true; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            board.isKinematic = false;
        }
    }
}
