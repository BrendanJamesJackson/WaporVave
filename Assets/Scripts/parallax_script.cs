using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax_script : MonoBehaviour
{
    public Rigidbody2D element_rb;
    public float scroll_speed;

    public game_controller gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<game_controller>();
    }

    // Update is called once per frame
    void Update()
    {
        element_rb.velocity = new Vector2(-scroll_speed * gm.getSpeedModifier(), 0f);
    }
}
