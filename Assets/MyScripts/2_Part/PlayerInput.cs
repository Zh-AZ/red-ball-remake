using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RedBallRemake.Inputs
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private Camera thirdView;
        [SerializeField] private Camera firstView;

        private AudioListener audioListenerFPV;
        private AudioListener audioListenerTPV;

        [SerializeField] private GameObject thirdPersonView;
        [SerializeField] private GameObject[] menuCanvas;
        private Vector3 movement;
        private PlayerMovement playerMovement;
        private MeshRenderer playerMeshRenderer;

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
            playerMeshRenderer = GetComponent<MeshRenderer>();
        }

        private void Start()
        {
            audioListenerFPV = firstView.GetComponent<AudioListener>();
            audioListenerTPV = thirdView.GetComponent<AudioListener>();

            SwitchFirstPerson();
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
                SwitchFirstPerson();
            }
            else if (Input.GetKeyDown(KeyCode.V) && thirdView.depth < 10)
            {
               SwitchThirdPerson();
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                //EventSystem.current.SetSelectedGameObject(null);

                foreach (GameObject canvas in menuCanvas)
                {
                    if (canvas.activeSelf)
                    {
                        canvas.SetActive(false);
                        Time.timeScale = 1;
                    }
                    else
                    {
                        canvas.SetActive(true);
                        Time.timeScale = 0;
                    }
                }
            }
        }

        private void FixedUpdate()
        {
            playerMovement.MoveCharacter(movement);
        }

        public void SwitchFirstPerson()
        {
            thirdView.depth = 0;
            firstView.depth = 10;
            playerMeshRenderer.enabled = false;
            audioListenerTPV.enabled = false;
            audioListenerFPV.enabled = true;
        }

        public void SwitchThirdPerson()
        {
            firstView.depth = 0;
            thirdView.depth = 10;
            playerMeshRenderer.enabled = true;
            audioListenerFPV.enabled = false;
            audioListenerTPV.enabled = true;
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

