
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Personaje : MonoBehaviour
{
    [SerializeField] private int velocidad = 5;

    public Collider2D swordHitbox;
    private Vector2 movement;
    private Rigidbody2D rig;
    private Animator animator;

    Collider2D swordCollider;
    

    private void Awake()
    {
        swordCollider = swordHitbox.GetComponentInChildren<Collider2D>();
        rig = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();

        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);

            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }

    private void OnFire() 
    {
        animator.SetTrigger("swordAttack");
    }

    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + movement * velocidad * Time.fixedDeltaTime);     
    }
}
