using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll_environment : MonoBehaviour

{
    public Rigidbody2D environment_rb;
    public float environment_speed;

    public game_controller gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameController").GetComponent<game_controller>();

    }

    // Update is called once per frame
    void Update()
    {
        environment_rb.velocity = new Vector2(-environment_speed * gm.getSpeedModifier(), 0f);
    }
}
