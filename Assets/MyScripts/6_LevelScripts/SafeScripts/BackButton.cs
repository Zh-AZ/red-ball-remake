using Unity.VisualScripting;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    [SerializeField] private GameObject safeCamera;
    [SerializeField] private GameObject player;
    private AudioListener audioListener;

    private void Start()
    {
        audioListener = safeCamera.GetComponent<AudioListener>();
    }

    public void OnButtonClick()
    {
        safeCamera.SetActive(false);
        player.SetActive(true);
        audioListener.enabled = false;
    }
}
