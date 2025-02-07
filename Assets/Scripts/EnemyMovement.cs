using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private float speed;
    public int health;

    void Update()
    {
        rb2d.velocity = Vector2.down * speed;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
