using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTrigger : MonoBehaviour
{
    [SerializeField] private GameObject evilBox;
    [SerializeField] private GameObject switchTrigger;
    private Animator anim;
    private float seconds;
    private bool isFromBottomToUp;

    // Start is called before the first frame update
    void Start()
    {
        anim = evilBox.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if (seconds >= 5)
       {
            switchTrigger.SetActive(false);
            seconds = 0;
       }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "SwitchTrigger" && isFromBottomToUp)
        {
            collision.gameObject.SetActive(false);
            isFromBottomToUp = false;
            anim.SetTrigger("WalkUpperTrigger");
        }
        else if (collision.gameObject.name == "SwitchTrigger")
        {
            seconds += Time.deltaTime;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "UpperTrigger")
        {
            switchTrigger.SetActive(true);
        }
        else if (other.gameObject.name == "BottomTrigger")
        {
            switchTrigger.SetActive(true);
            isFromBottomToUp = true;
        }
    }
}
