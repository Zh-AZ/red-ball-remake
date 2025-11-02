using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] private GameObject player; 
    [SerializeField] private GameObject winCamera;
    [SerializeField] private GameObject winCanvas;
    [SerializeField] private AudioSource winSound; 
    [SerializeField] private AudioClip winClip; 


    // Start is called before the first frame update
    void Start()
    {
        winSound = winSound.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winCanvas.SetActive(true);
            winSound.clip = winClip; 
            winSound.Play(); 
            player.SetActive(false); 
            winCamera.SetActive(true);
        }
    }
}
