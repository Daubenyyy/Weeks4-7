using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardChange : MonoBehaviour
{
    public float guard;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        changeGuard();
    }

    void changeGuard()
    {
        if (guard == 0) animator.SetBool("HighGuard", true);
        else animator.SetBool("HighGuard", false);

        if (guard == 1) animator.SetBool("MidGuard", true);
        else animator.SetBool("MidGuard", false);

        if (guard == 2) animator.SetBool("LowGuard", true);
        else animator.SetBool("LowGuard", false);
    }

    public void guardSlider(float g)
    {
        guard = g;
    }
}
