using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_environment : MonoBehaviour

{
    public Rigidbody2D environment_rb;
    public float environment_speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        environment_rb.velocity = new Vector2(-environment_speed, 0f);
    }
}
