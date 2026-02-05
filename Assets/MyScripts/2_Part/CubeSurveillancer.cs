using UnityEngine;

public class CubeSurveillancer : MonoBehaviour
{
    [SerializeField] private GameObject surveillanceCamera;
    [SerializeField] private GameObject playerCameraFPV;
    [SerializeField] private GameObject playerCameraTPV;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            surveillanceCamera.SetActive(true);
            playerCameraFPV.SetActive(false);
            playerCameraTPV.SetActive(false);
        }
    }
}
