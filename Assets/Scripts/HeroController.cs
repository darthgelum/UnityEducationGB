using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40;
    public Transform gunSlot;
    public Transform eyesSlot;
    float horizontalMove = 0f;
    bool jump = false;
    // Update is called once per frame
    void Update()
    {
      
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        if(Input.GetButtonDown("Jump"))
        {
            animator.SetInteger("Jump", 2);
            jump = true;
        }
    }
    public void OnLanding()
    {
        var j = animator.GetInteger("Jump");
        if(j<=0)
        {
            j = 1;
        }
        j = j--;
        animator.SetInteger("Jump", --j);
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove*Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
