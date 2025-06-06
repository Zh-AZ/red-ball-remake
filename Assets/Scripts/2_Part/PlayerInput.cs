using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedBallRemake.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private Camera thirdView;
        [SerializeField] private Camera firstView;
        [SerializeField] private GameObject thirdPersonView;
        private Vector3 movement;
        private PlayerMovement playerMovement;

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (thirdView.depth == 10)
            {
                FollowCamera(thirdView);
            }
            else
            {
                FollowCamera(firstView);
            }

            if (Input.GetKeyDown(KeyCode.V) && thirdView.depth == 10)
            {
                thirdView.depth = 0;
                firstView.depth = 10;
            }
            else if (Input.GetKeyDown(KeyCode.V) && thirdView.depth < 10) 
            {
                firstView.depth = 0;
                thirdView.depth = 10;
            }
        }

        private void FixedUpdate()
        {
            playerMovement.MoveCharacter(movement);
        }

        private void FollowCamera(Camera camera)
        {
            float horizontal = Input.GetAxis(GlobalStringVars.Horizontal_Axis);
            float vertical = Input.GetAxis(GlobalStringVars.Vertical_Axis);

            Vector3 camForward = camera.transform.forward;
            Vector3 camRight = camera.transform.right;

            camForward.y = 0;
            camRight.y = 0;
            camForward.Normalize();
            camRight.Normalize();

            movement = (camForward * vertical + camRight * horizontal).normalized;
        }
    }
}

