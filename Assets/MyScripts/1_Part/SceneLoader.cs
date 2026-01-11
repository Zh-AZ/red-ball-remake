using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace RedBallRemake.Inputs 
{
    public class SceneLoader : PlayerInventory
    {
        [SerializeField] private int sceneIndex;

        private void Start()
        {
        }

        public void ResetScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            items.Clear();

            //hasKey = false;
            //hasHose = false;
            //hasElectricity = false;
            //hasShovel = false;

            //hasCanisterFuel = false;
            //hasCanister = false;

            //hasScrewdriver = false;
            //hasHammer = false;
            //hasBurglarKeys = false;
        }

        public void LoadScene(int scene)
        {
            SceneManager.LoadScene(scene);
        }

        public void Pause(bool isResume)
        {
            if (isResume)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                LoadScene(sceneIndex);
            }
        }
    }
}

