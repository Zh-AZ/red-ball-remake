using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private GameObject evilBox;
    [SerializeField] private GameObject leftTrigger;
    [SerializeField] private GameObject rightTrigger;
    [SerializeField] private GameObject centerTrigger;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float force;
    private float seconds;
    private bool isGoTimer;
    private bool isLeftSide;
    private bool isRightSide;
    private bool isCenterLeftSide;
    private bool isCenterRightSide;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = evilBox.GetComponent<Animator>();
        //rb.AddForce(Vector3.right * 1.5f, ForceMode.Impulse);
        isLeftSide = true;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Velocity", rb.velocity.magnitude);

        if (isGoTimer)
        {
            seconds += Time.deltaTime;
        }

        if (gameObject.CompareTag("EvilBox_1"))
        {
            if (isLeftSide && seconds == 0)
            {
                rb.AddForce(Vector3.right * force, ForceMode.Impulse);
            }
            else if (isRightSide && seconds == 0)
            {
                rb.AddForce(Vector3.left * force, ForceMode.Impulse);
            }
        }
        else
        {
            if (isLeftSide && seconds == 0)
            {
                rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
            }
            else if (isRightSide && seconds == 0)
            {
                rb.AddForce(Vector3.back * force, ForceMode.Impulse);
            }
        }


        if (seconds >= 3)
        {
            isGoTimer = false;
            seconds = 0;
        }

        if (isCenterLeftSide && seconds >= 1 && seconds < 2)
        {
            anim.SetTrigger("LookLeftToBack");
        }
        else if (isCenterLeftSide && seconds >= 2.80)
        {
            anim.SetTrigger("LookStraightFromLeft");
        }
        else if (isCenterLeftSide && isGoTimer == false)
        {
            isCenterLeftSide = false;
        }

        if (isCenterRightSide && seconds >= 1 && seconds < 2)
        {
            anim.SetTrigger("LookRightToBack");
        }
        else if (isCenterRightSide && seconds >= 2.80)
        {
            anim.SetTrigger("LookStraightFromRight");
        }
        else if (isCenterRightSide && isGoTimer == false)
        {
            isCenterRightSide = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        rb.isKinematic = true;
        rb.isKinematic = false;
        isGoTimer = true;

        if (other.CompareTag("LeftTrigger"))
        {
            isLeftSide = true;
            isRightSide = false;
            leftTrigger.SetActive(false);
            rightTrigger.SetActive(true);
            if (gameObject.CompareTag("EvilBox_1"))
            {
                centerTrigger.SetActive(true);
            }
            anim.SetTrigger("TurnRightTrigger");
        }
        else if (other.CompareTag("RightTrigger"))
        {
            isRightSide = true;
            isLeftSide = false;
            rightTrigger.SetActive(false);
            leftTrigger.SetActive(true);
            if (gameObject.CompareTag("EvilBox_1"))
            {
                centerTrigger.SetActive(true);
            }
            anim.SetTrigger("TurnLeftTrigger");
        }
        else if (other.CompareTag("CenterTrigger"))
        {
            centerTrigger.SetActive(false);
            leftTrigger.SetActive(true);
            rightTrigger.SetActive(true);
            
            if (isLeftSide)
            {
                anim.SetTrigger("LookLeft");
                isCenterLeftSide = true;
            }
            else if (isRightSide)
            {
                anim.SetTrigger("LookRight");
                isCenterRightSide = true;
            }
        }
    }
}
