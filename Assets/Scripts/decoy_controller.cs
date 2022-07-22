using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decoy_controller : MonoBehaviour
{
    public int numPops = 5;
    public GameObject[] popArr;
    public GameObject container;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            //pop-up window, randomly choose from array
        }
    }
}
