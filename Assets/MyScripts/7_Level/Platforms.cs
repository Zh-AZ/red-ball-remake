using UnityEngine;
using System.Collections;

public class Platforms : MonoBehaviour
{
    [SerializeField] protected GameObject platform_1;
    [SerializeField] protected GameObject platform_2;
    [SerializeField] protected GameObject platform_3;

    [SerializeField] protected bool isLever_1;
    [SerializeField] protected bool isLever_2;
    [SerializeField] protected bool isLever_3;


    protected IEnumerator ChangePosition(Vector3 firstPlatformPosition, Vector3 secondPlatformPosition, Vector3 thirdPlatformPosition)
    {
        StartCoroutine(FirstLoop(firstPlatformPosition));
        StartCoroutine(SecondLoop(secondPlatformPosition));
        StartCoroutine(ThirdLoop(thirdPlatformPosition));

        ActivatePlatform(0);
        
        yield return null;
    }

    protected IEnumerator FirstLoop(Vector3 firstPlatformPosition)
    {
        while (platform_1.transform.position != firstPlatformPosition)
        {
            platform_1.transform.position = Vector3.MoveTowards(platform_1.transform.position, firstPlatformPosition, 2f * Time.deltaTime);

            yield return null;
        }
    }

    protected IEnumerator SecondLoop(Vector3 secondPlatformPosition)
    {
        while (platform_2.transform.position != secondPlatformPosition)
        {
            platform_2.transform.position = Vector3.MoveTowards(platform_2.transform.position, secondPlatformPosition, 2f * Time.deltaTime);

            yield return null;
        }
    }

    protected IEnumerator ThirdLoop(Vector3 thirdPlatformPosition)
    {
        while (platform_3.transform.position != thirdPlatformPosition)
        {
            platform_3.transform.position = Vector3.MoveTowards(platform_3.transform.position, thirdPlatformPosition, 2f * Time.deltaTime);

            yield return null;
        }
    }

    protected void ActivatePlatform(int platformNumber)
    {
        isLever_1 = platformNumber == 1;
        isLever_2 = platformNumber == 2;
        isLever_3 = platformNumber == 3;
    }
}       
