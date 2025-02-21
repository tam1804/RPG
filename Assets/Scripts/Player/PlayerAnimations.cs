using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerAnimations : MonoBehaviour
{
    private readonly int moveX = Animator.StringToHash(name: "MoveX");
    private readonly int moveY = Animator.StringToHash(name: "MoveY");
    private readonly int moving = Animator.StringToHash(name: "Moving");
    private readonly int dead = Animator.StringToHash(name: "Dead");
    private readonly int revive = Animator.StringToHash(name: "Revive");
    
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetDeadAnimation()
    {
        animator.SetTrigger(dead);
    }
    public void SetMoveboolTransition(bool value)
    {
    animator.SetBool(moving, value);
    }
    public void SetMoveAnimation(Vector2 dir)
    {
        animator.SetFloat(moveX, dir.x);
        animator.SetFloat(moveY, dir.y);
    }
    public void ResetPlayer()
    {
        SetMoveAnimation(Vector2.down);
        animator.SetTrigger(revive); 
    }
}
