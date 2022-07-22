using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax_controller : MonoBehaviour
{

    public repeat_parallax parallax_repeat;
    public string para_type;

    // Start is called before the first frame update
    void Start()
    {
       /* parallax_repeat = GameObject.FindGameObjectWithTag(para_type).GetComponent<repeat_parallax>();
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), GameObject.FindGameObjectWithTag("ParaOut").GetComponent<Collider2D>(), false);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "")
        {
            parallax_repeat.parallax_update();
        }
    }*/
}
