using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;

    private int MAX_HEALTH = 100;

    void Update()
    { 
        if(Input.GetKeyDown(KeyCode.D))
        {
        //    Damage(10);
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
        //    Heal(10);
        }

    }

    public void SetHealth(int maxHealth, int health)
    {
        this.MAX_HEALTH = maxHealth;
        this.health = health;
    }

    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentException("Dano debe ser positivo");
        }

        this.health -= amount;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentException("Curacion debe ser positiva");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

        if(wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }

        this.health += amount;
    }

    private void Die()
    {
        Debug.Log("Muerto");
        Destroy(gameObject);
    }
}
