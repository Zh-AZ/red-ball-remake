using RedBallRemake.Inputs;
using UnityEngine;

public class ExitSafeCamera : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject lockCamera;
    [SerializeField] private PlayerInput playerInput;
    private AudioListener audioListener;

    private void Start()
    {
        audioListener = gameObject.GetComponent<AudioListener>();
        playerInput = playerInput.GetComponent<PlayerInput>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && player.activeSelf == false && lockCamera.activeSelf == false)
        {
            SwitchSafeCamera();
        }
    }

    /// <summary>
    /// Перейти к игроку включив его камеру
    /// </summary>
    public void SwitchSafeCamera()
    {
        player.SetActive(true);
        audioListener.enabled = false;
        playerInput.SwitchFirstPerson();
    }
}
