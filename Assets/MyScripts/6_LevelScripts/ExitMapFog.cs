using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ExitMapFog : MonoBehaviour
{
    [SerializeField] private Rigidbody player;
    [SerializeField] private Image fogImage;
    public static ExitMapFog Instance;
    


    Coroutine fadeRoutine;
    bool playerInside;

    private void Awake()
    {
        player = player.GetComponent<Rigidbody>();
        Instance = this;
    }

    public void EnterZone()
    {
        //if (!other.CompareTag("Player")) return;

        playerInside = true;
        StartFade(3f);
    }

    public void ExitZone()
    {
        //if (!other.CompareTag("Player")) return;

        playerInside = false;
        StartFade(0f);
    }

    void StartFade(float target)
    {
        if (fadeRoutine != null)
            StopCoroutine(fadeRoutine);

        fadeRoutine = StartCoroutine(FadeTo(target));
    }

    IEnumerator FadeTo(float target)
    {
        while (!Mathf.Approximately(fogImage.color.a, target))
        {
            var c = fogImage.color;
            c.a = Mathf.MoveTowards(c.a, target, Time.deltaTime * 0.1f);
            //c.a = Mathf.Lerp(c.a, target, 1 - Mathf.Exp(-2f * Time.deltaTime));
            fogImage.color = c;

            if (c.a >= 0.99f && playerInside)
            {
                player.position = GeneratRandomPosition();
                //player.position = new Vector3(-0.37f, 0.9785688f, 52.83f);
                player.linearVelocity = Vector3.zero;
                //TeleportPlayer(new Vector3(-0.37f, 0.9785688f, 52.83f));
                Debug.Log("Player Teleported");
                //player.transform.position = new Vector3(-0.37f, 0.9785688f, 52.83f);
                StartFade(0f);
                yield break;
            }

            yield return null;
        }
    }

    // 37.25539 0.9882324 5.580494
    // 16.345 0.9882324 -40.206
    //  -31.98843 1.157 -11.96516

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

    void TeleportPlayer(Vector3 pos)
    {
        var cc = player.GetComponent<CharacterController>();

        if (cc != null)
            cc.enabled = false;

        player.transform.position = pos;
        //player.transform.rotation = Quaternion.Euler(0, 180, 0);

        if (cc != null)
            cc.enabled = true;
    }


    //// Start is called once before the first execution of Update after the MonoBehaviour is created
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        StopCoroutine(FogDiffusion());

    //        var alpha = fogImage.color;
    //        alpha.a = Mathf.Lerp(fogImage.color.a, 1, Time.deltaTime * 0.2f);
    //        fogImage.color = alpha;

    //        //RenderSettings.fogDensity = Mathf.Lerp(RenderSettings.fogDensity, 1, Time.deltaTime * 0.1f);


    //        if (fogImage.color.a >= 1f)
    //        {
    //            player.transform.position = new Vector3(-0.37f, 0.9785688f, 52.83f);
    //        }
    //    }
    //}

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        StartCoroutine(FogDiffusion());
    //    }
    //}

    //private IEnumerator FogDiffusion()
    //{
    //    var alpha = fogImage.color;

    //    while (fogImage.color.a > 0f)
    //    {
    //        alpha.a = Mathf.Lerp(fogImage.color.a, 0, Time.deltaTime * 0.5f);
    //        fogImage.color = alpha;
    //        yield return null;
    //    }

    //    //RenderSettings.fogDensity = Mathf.Lerp(RenderSettings.fogDensity, 0.05f, Time.deltaTime * 0.5f);
    //}

    //private IEnumerator FogNebula()
    //{
    //    var alpha = fogImage.color;

    //    while (fogImage.color.a < 255f)
    //    {
    //        alpha.a = Mathf.Lerp(fogImage.color.a, 1, Time.deltaTime * 0.2f);
    //        fogImage.color = alpha;
    //        yield return null;
    //    }

    //    player.transform.position = new Vector3(-0.37f, 0.9785688f, 52.83f);

    //    //RenderSettings.fogDensity = Mathf.Lerp(RenderSettings.fogDensity, 1, Time.deltaTime * 0.1f);


    //}
}
