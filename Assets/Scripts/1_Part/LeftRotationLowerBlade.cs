using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRotation : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("IsLeftRotation", true);
    }
}
