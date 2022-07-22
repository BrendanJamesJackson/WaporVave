using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_controller : MonoBehaviour
{
    public int points;
    private game_controller gc;
    private int type;
    public float speed = 5f;
    private Rigidbody2D enemy_rb;
    
    // Start is called before the first frame update
    void Start()
    {
        enemy_rb = gameObject.GetComponent<Rigidbody2D>();
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<game_controller>();
    }

    private void FixedUpdate()
    {
        enemy_rb.velocity = new Vector2(-speed, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            enemyDie();
        }
    }

    public void enemyDie()
    {
        gc.incScore(points);
        //particle effect
        //sound
        Destroy(gameObject);
    }
}
