using System.Collections;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class TakeThingsEffect : PlayerInventory
{
    [SerializeField] private GameObject item;
    [SerializeField] private TMP_Text[] interactText;
    [SerializeField] private ParticleSystem pickupEffect;
    private Animator pickupAnimation;

    private void Start()
    {
        pickupEffect = pickupEffect.GetComponent<ParticleSystem>();
        pickupAnimation = item.GetComponent<Animator>();
    }

    /// <summary>
    /// Показать соответсвующий текст при входе в триггер
    /// </summary>
    /// <param name="itemId"></param>
    /// <param name="message"></param>
    protected void EnterTrigger(string itemId, string message)
    {
        foreach (TMP_Text text in interactText)
        {
            if (HasItem(itemId))
            {
                text.gameObject.SetActive(false);
            }
            else
            {
                text.gameObject.SetActive(true);
            }

            text.text = $"{message}";
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(WaitForPickupEffect(itemId));
        }
    }

    /// <summary>
    /// Отключение текста при выходе из триггера
    /// </summary>
    protected void ExitTrigger()
    {
        foreach (TMP_Text text in interactText)
            text.gameObject.SetActive(false);
    }

    /// <summary>
    /// Запуск анимации, эффекта и добавление в инвентарь при подборе предмета
    /// </summary>
    /// <param name="itemId"></param>
    /// <returns></returns>
    private IEnumerator WaitForPickupEffect(string itemId)
    {
        pickupAnimation.SetTrigger("PickedUp");
        yield return new WaitForSeconds(0.50f);
        pickupEffect.Play();

        AddItem(itemId);

        gameObject.SetActive(false);
        item.SetActive(false);

        foreach (TMP_Text text in interactText)
            text.gameObject.SetActive(false);
    }
}
