using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_controller : MonoBehaviour
{
    private Rigidbody2D bullet_rb;
    public float bullet_speed = 10f;

    private void Start()
    {
        bullet_rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        bullet_rb.velocity = new Vector2(bullet_speed, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {    
        Destroy(gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
