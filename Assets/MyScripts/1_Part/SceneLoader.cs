using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace RedBallRemake.Inputs 
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private int sceneIndex;

        public void ResetScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerInventory.ClearInventory();
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

