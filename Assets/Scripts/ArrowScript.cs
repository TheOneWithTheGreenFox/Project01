using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    public float speed;
    public int damage;

    // Update is called once per frame
    void Start()
    {
        rb2d.velocity = Vector2.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            collision.gameObject.GetComponent<EnemyMovement>().health -= damage;
        }

        Destroy(gameObject);
    }
}
