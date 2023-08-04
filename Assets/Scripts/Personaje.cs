using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] private float velocidad;

    private Rigidbody2D rig;
    private Vector2 moveInput;
    private Animator anim;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;

        anim.SetFloat("Horizontal", moveX);
        anim.SetFloat("Vertical", moveY);
        anim.SetFloat("Speed", moveInput.sqrMagnitude);

    }


    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + moveInput * velocidad * Time.fixedDeltaTime);
        anim.SetFloat("Camina", Mathf.Abs(rig.velocity.magnitude));
    }
}
