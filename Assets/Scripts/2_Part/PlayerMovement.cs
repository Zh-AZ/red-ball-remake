using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedBallRemake.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 3.0f;
        [SerializeField] private float jumpForce;
        [SerializeField] private Transform followTarget;
        private Rigidbody playerRigidbody;
        private bool canJump = true;

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
            followTarget.position = transform.position;

            if (Input.GetButtonDown(GlobalStringVars.Jump_Button) && canJump)
            {
                playerRigidbody.AddForce(Vector3.up * jumpForce);
                canJump = false;
                StartCoroutine(WaitTime());
            }
        }

        public void MoveCharacter(Vector3 movement)
        {
            playerRigidbody.AddForce(movement * speed);
        }

        private IEnumerator WaitTime()
        {
            yield return new WaitForSeconds(1);
            canJump = true;
        }

#if UNITY_EDITOR

        [ContextMenu("Reset Values")]
        public void ResetValues()
        {
            speed = 3.0f;
        }

#endif
    }
}

