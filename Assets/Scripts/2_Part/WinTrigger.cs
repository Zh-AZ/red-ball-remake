using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] private GameObject player; // Reference to the player GameObject
    [SerializeField] private GameObject winCamera;
    [SerializeField] private GameObject winCanvas;
    [SerializeField] private AudioSource winSound; // Optional: sound to play on win
    [SerializeField] private AudioClip winClip; // Optional: sound clip to play on win


    // Start is called before the first frame update
    void Start()
    {
        winSound = winSound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winCanvas.SetActive(true);
            winSound.clip = winClip; // Set the clip to play
            winSound.Play(); // Play the win sound
            player.SetActive(false); // Disable the player GameObject
            winCamera.SetActive(true); // Activate the win camera
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;
        }
    }
}
