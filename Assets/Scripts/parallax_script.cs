using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax_script : MonoBehaviour
{
    public Rigidbody2D element_rb;
    public float scroll_speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        element_rb.velocity = new Vector2(-scroll_speed, 0f);
    }
}
