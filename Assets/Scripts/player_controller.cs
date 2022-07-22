using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    public Rigidbody2D player_rb;
    public float player_jumpforce;

    public bool player_isgrounded;


    public LayerMask groundLayer;

    private game_controller gc; //game controller script - end game, change score, etc.

    private void Update()
    {
        player_isgrounded = isGrounded();
    }

    void FixedUpdate()
    {
        if ((Input.GetAxis("Jump") > 0) && (player_isgrounded))
        {
            player_rb.AddForce(new Vector2(0f, player_jumpforce));
        }
    }

    bool isGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 0.6f;

        Debug.DrawRay(position, direction*0.6f, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }
        return false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            gc.gameOver();
        }
    }
}
