using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedBallRemake.Inputs
{
    public class CameraMovement : MonoBehaviour
    {
        [SerializeField] private Transform playerTransform;
        private Vector3 offset;

        private void Awake()
        {
            offset = transform.position - playerTransform.position;
        }

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private void FixedUpdate()
        {
            transform.position = playerTransform.position + offset;
        }
    }
}

