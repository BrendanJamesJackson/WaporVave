using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decoy_controller : MonoBehaviour
{
    public int numPops = 5;
    public GameObject[] popArr;
    public GameObject container;
    public float speed = 5f;
    private Rigidbody2D decoy_rb;

    private Material material;
    private float fade = 1f;
    private bool isDissolving = false;
    
    // Start is called before the first frame update
    void Start()
    {
        decoy_rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        decoy_rb.velocity = new Vector2(-speed, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            //pop-up window, randomly choose from array
            isDissolving = true;
            Fade();
        }
    }

    private void Fade()
    {
        if (isDissolving)
        {
            fade -= Time.deltaTime;

            if (fade <= 0f)
            {
                fade = 0f;
                isDissolving = false;
            }

            // Set the property
            material.SetFloat("_Fade", fade);
        }
    }
}
