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

        private void FixedUpdate()
        {
            transform.position = playerTransform.position + offset;
        }
    }
}

