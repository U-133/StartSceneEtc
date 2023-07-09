using System.Collections;
using System.Collections.Generic;
using UnityEngine;
{
    [SerializeField] protected float damage;

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            collision.GetComponent<HealthController>().DecreaseHealth(1);
    }
}