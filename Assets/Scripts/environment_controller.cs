using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class environment_controller : MonoBehaviour
{
    public repeat_environment enviro_repeat;

    // Start is called before the first frame update
    void Start()
    {
        enviro_repeat = GameObject.FindGameObjectWithTag("GameController").GetComponent<repeat_environment>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EnviroExit")
        {
            enviro_repeat.enviro_update();
        }
    }
}
