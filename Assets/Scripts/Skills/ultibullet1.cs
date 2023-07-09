using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ultibullet1 : MonoBehaviour
{
    public float speed = 15f;
    public Rigidbody2D rb;
    public event System.Action OnBulletCollision;

    private bool isFacingRight = true; // Karakterin sağa dönük olduğunu takip eden bir flag

    void Start()
    {
        rb.velocity = (isFacingRight ? transform.right : -transform.right) * speed;
    }

    public void SetDirection(bool isRight)
    {
        isFacingRight = isRight;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject); 
            OnBulletCollision?.Invoke();
        }
    }

}
