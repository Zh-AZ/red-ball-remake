using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedBallRemake.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2.0f;
        private Rigidbody playerRigidbody;

        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void MoveCharacter(Vector3 movement)
        {
            playerRigidbody.AddForce(movement * speed);
        }

#if UNITY_EDITOR

        [ContextMenu("Reset Values")]
        public void ResetValues()
        {
            speed = 2.0f;
        }

#endif
    }
}

