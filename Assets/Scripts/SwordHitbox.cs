using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    public float swordDamage = 1f;
    public Collider2D swordCollider;

    void Start()
    {
        if(swordCollider == null)
        {
            Debug.LogWarning("Sword Collider not set");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        col.collider.SendMessage("OnHit", swordDamage);
        
    }

}
