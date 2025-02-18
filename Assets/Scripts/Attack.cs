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
        animator = GetComponent<Animator>(); //get animator
    }

    
    void Update()
    {
        attack();
    }

    void attack()
    {
        if (attacking == true) //checks if attacking is true
        {
            animator.SetBool("Attack", true); //activate attack animation
            attackTimer += Time.deltaTime; //start timer
        }
        if (attackTimer >= 0.083)
        {
            attacking = false; //disable timer
            animator.SetBool("Attack", false); //disable attack animation
            attackTimer = 0; //reset timer
        }
    }

    public void attackButton() //set attacking to true when button UI is pressed
    {
        attacking = true;
    }
    
}
