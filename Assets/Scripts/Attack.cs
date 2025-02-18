using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public bool attacking;
    public float attackTimer;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        attack();
    }

    void attack()
    {
        if (attacking == true)
        {
            animator.SetBool("Attack", true);
            attackTimer += Time.deltaTime;
        }
        if (attackTimer >= 0.083)
        {
            attacking = false;
            animator.SetBool("Attack", false);
            attackTimer = 0;
        }
    }

    public void attackButton()
    {
        attacking = true;
    }
    
}
