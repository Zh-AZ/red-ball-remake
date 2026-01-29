using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject startMenu;

    public void StartGameButton()
    {
        player.SetActive(true);
        startMenu.SetActive(false);
    }
}
