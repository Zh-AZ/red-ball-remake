using UnityEngine;
using System.Collections;
using Unity.VisualScripting;


public class SecondPlatform : Platforms
{
    void Update()
    {
        if (isLever_1)
        {
            StartCoroutine(ChangePosition(new Vector3(6.5003528f, -7.02794075f, 35.5195274f), new Vector3(-4.50043297f, 6.82985592f, 35.5195313f),
                new Vector3(2.98022655e-08f, -0.869087219f, 41.8999023f)));
        }
        else if (isLever_2)
        {
            StartCoroutine(ChangePosition(new Vector3(6.50035286f, -0.386169434f, 35.5195274f), new Vector3(-4.50043297f, 6.83847713f, 35.5195313f),
                new Vector3(2.98022655e-08f, -7.52070951f, 41.8999023f)));
        }
        else if (isLever_3)
        {
            StartCoroutine(ChangePosition(new Vector3(6.50035286f, 6.83769417f, 35.5195274f), new Vector3(-4.50043297f, 6.83847713f, 35.5195313f),
                new Vector3(2.98022655e-08f, -0.879981041f, 41.8999023f)));
        }
    }
}
