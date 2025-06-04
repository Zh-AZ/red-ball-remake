using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RedBallRemake.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
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
            float horizontal = Input.GetAxis(GlobalStringVars.Horizontal_Axis);
            float vertical = Input.GetAxis(GlobalStringVars.Vertical_Axis);
            
            movement = new Vector3(-horizontal, 0,-vertical).normalized;
        }

        private void FixedUpdate()
        {
            playerMovement.MoveCharacter(movement);
        }
    }
}

