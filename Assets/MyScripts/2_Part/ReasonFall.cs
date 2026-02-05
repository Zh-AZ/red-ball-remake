using RedBallRemake.Inputs;
using System.Collections;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Animations;

public class ReasonFall : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private MeshRenderer playerMeshRenderer;

    private void Start()
    {
        playerMeshRenderer = playerMeshRenderer.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);

        if (gameObject == true)
        {
            StartCoroutine(RestartSceneDelay());
        }
    }

    private IEnumerator RestartSceneDelay()
    {
        playerMeshRenderer.enabled = true;
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(3f);
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
