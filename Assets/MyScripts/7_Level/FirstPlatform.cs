using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class FirstPlatform : Platforms
{
    void Update()
    {
        if (isLever_1)
        {
            StartCoroutine(ChangePosition(new Vector3(6.50035286f, -0.389999986f, 35.5195274f), new Vector3(-4.50043297f, 6.82999992f, 35.5195313f),
                new Vector3(2.98022655e-08f, -0.889999986f, 41.8999023f)));
        }
        else if (isLever_2)
        {
            StartCoroutine(ChangePosition(new Vector3(6.50035286f, 6.82857227f, 35.5195274f), new Vector3(-4.50043297f, 6.82999992f, 35.5195313f),
                new Vector3(2.98022655e-08f, -7.51000023f, 41.8999023f)));
        }
        else if (isLever_3)
        {
            StartCoroutine(ChangePosition(new Vector3(6.50035286f, -7.02794075f, 35.5195274f), new Vector3(-4.50043297f, -0.383581161f, 35.5195313f),
                new Vector3(2.98022655e-08f, 6.3211832f, 41.8999023f)));
        }
    }
}

