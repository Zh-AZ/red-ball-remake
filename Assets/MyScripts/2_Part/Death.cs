using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private ParticleSystem deathEffect;

    private void Start()
    {
        deathEffect = deathEffect.GetComponent<ParticleSystem>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(WaitForDeathEffect());
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            Destroy(other.gameObject);
        }
    }

    IEnumerator WaitForDeathEffect()
    {
        player.SetActive(false);
        deathEffect.Play();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
