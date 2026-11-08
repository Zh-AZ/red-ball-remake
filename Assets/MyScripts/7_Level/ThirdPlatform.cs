using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class ThirdPlatform : Platforms
{
    void Update()
    {
        if (isLever_1)
        {
            StartCoroutine(ChangePosition(new Vector3(6.50035286f, -0.389421463f, 35.5195274f), new Vector3(-4.50043297f, -7.01640654f, 35.5195313f),
                new Vector3(2.98022655e-08f, -0.879981041f, 41.8999023f)));
        }
        else if (isLever_2)
        {
            StartCoroutine(ChangePosition(new Vector3(6.50035286f, -7.02794075f, 35.5195274f), new Vector3(-4.50043297f, -6.99358702f, 35.5195313f),
                new Vector3(2.98022655e-08f, -7.52654886f, 41.8999023f)));
        }
        else if (isLever_3)
        {
            StartCoroutine(ChangePosition(new Vector3(6.50035286f, 6.97205925f, 35.5195274f), new Vector3(-4.50043297f, 6.97303677f, 35.5195313f),
                new Vector3(2.98022655e-08f, -7.53165865f, 41.8999023f)));
        }
    }
}
