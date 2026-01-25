using RedBallRemake.Inputs;
using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ExitMapFog : MonoBehaviour
{
    [SerializeField] private Rigidbody player;
    [SerializeField] private Image fogImageFPV;
    [SerializeField] private Image fogImageTPV;
    private PlayerInput playerInput;
    public static ExitMapFog Instance;

    Coroutine fadeRoutine;
    bool playerInside;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        playerInput = player.GetComponent<PlayerInput>();
        player = player.GetComponent<Rigidbody>();
    }

    public void EnterZone()
    {
        playerInside = true;
        StartFade(3f);
    }

    public void ExitZone()
    {
        playerInside = false;
        StartFade(0f);
    }

    void StartFade(float target)
    {
        if (fadeRoutine != null)
            StopCoroutine(fadeRoutine);

        fadeRoutine = StartCoroutine(FadeTo(target));
    }

    /// <summary>
    /// ѕостепенное по€вление/исчезновение тумана
    /// </summary>
    /// <param name="target"></param>
    /// <returns></returns>
    IEnumerator FadeTo(float target)
    {
        while (!Mathf.Approximately(fogImageFPV.color.a, target))
        {
            var c = fogImageFPV.color;
            c.a = Mathf.MoveTowards(c.a, target, Time.deltaTime * 0.1f);
            fogImageFPV.color = c;
            fogImageTPV.color = c;

            if (c.a >= 0.99f && playerInside)
            {
                player.position = GeneratRandomPosition();
                player.linearVelocity = Vector3.zero;

                playerInput.SwitchFirstPerson();

                Debug.Log("Player Teleported");
                StartFade(0f);
                yield break;
            }

            yield return null;
        }
    }

    //  оординаты спавнов игрока:
    // A: 37.25539 0.9882324 5.580494
    // B: 16.345 0.9882324 -40.206
    // C: -31.98843 1.157 -11.96516

    /// <summary>
    /// —павн в рандомное место при выходе из игровой зоны
    /// </summary>
    /// <returns></returns>
    private Vector3 GeneratRandomPosition()
    {
        Vector3 positionA = new Vector3(37.25539f, 0.9882324f, 5.580494f);
        Vector3 positionB = new Vector3(16.345f, 0.9882324f, -40.206f);
        Vector3 positionC = new Vector3(-31.98843f, 1.157f, -11.96516f);
        Vector3 positionD = new Vector3(-0.37f, 0.9785688f, 52.83f);

        Vector3[] positions = new Vector3[] { positionA, positionB, positionC, positionD };
        int randomIndex = Random.Range(0, positions.Length);
        return positions[randomIndex];
    }
}
