using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTag : MonoBehaviour
{
    /// <summary>
    /// ����� ���� ������ ��� ����� � ���������� ����
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.tag = "HiddenPlayer";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("HiddenPlayer"))
        {
            other.gameObject.tag = "Player";
        }
    }
}
