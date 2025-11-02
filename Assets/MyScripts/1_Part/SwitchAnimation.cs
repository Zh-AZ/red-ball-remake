using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchAnimation : MonoBehaviour
{
    private Animator animator;
    private int rand;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        rand = Random.Range(0, 3);
        animator.SetInteger("Random", rand);
        
        if (rand == 2)
        {
            string currentAnimationName = animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;
            animator.Play(currentAnimationName, 0, 0f);
        }
    }
}
