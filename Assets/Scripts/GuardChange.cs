using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardChange : MonoBehaviour
{
    public float guard;

    private Animator animator;

    void Start()
    {
        //getting animator component
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        changeGuard();
    }

    void changeGuard()
    {
        //checking guard number. set animation to true if guard number matches, otherwise be false
        if (guard == 0) animator.SetBool("HighGuard", true);
        else animator.SetBool("HighGuard", false);

        if (guard == 1) animator.SetBool("MidGuard", true);
        else animator.SetBool("MidGuard", false);

        if (guard == 2) animator.SetBool("LowGuard", true);
        else animator.SetBool("LowGuard", false);
    }

    public void guardSlider(float g) //allows slider UI to change the guard #
    {
        guard = g;
    }
}
