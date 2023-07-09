using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int maxHealth = 5;
    [SerializeField] private int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void DecreaseHealth(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
}
