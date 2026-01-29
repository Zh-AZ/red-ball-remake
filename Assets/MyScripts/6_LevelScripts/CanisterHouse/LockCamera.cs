using UnityEngine;

public class LockCamera : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject originalLock;
    [SerializeField] private GameObject fakeLock;
    [SerializeField] private GameObject trigger;
    [SerializeField] private GameObject cursorChecker;
    [SerializeField] private LockPikingGame lockPikingGame;


    private void Start()
    {
        lockPikingGame = lockPikingGame.GetComponent<LockPikingGame>();
    }

    /// <summary>
    /// Переход к камере взлома замка и отключение курсора
    /// </summary>
    void Update()
    {
        if (gameObject)
        {
            cursorChecker.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            lockPikingGame.Reset();
            cursorChecker.SetActive(true);
            player.SetActive(true);
            originalLock.SetActive(false);
            fakeLock.SetActive(true);
            trigger.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
