using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Поле зрение врагов
/// </summary>
public class EvilBoxVision : MonoBehaviour
{
    [SerializeField] private Transform target;       
    [SerializeField] private float offsetX = 5.0f;   

    
    void Update()
    {
        Vector3 localOffset = new Vector3(offsetX, 0f, 0f);
        transform.position = target.TransformPoint(localOffset);
        transform.rotation = target.rotation;
    }
}
