using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeat_parallax : MonoBehaviour
{
    public GameObject[] parallax_array;

    public GameObject[] parallax_prefab;

    public float parallax_offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void parallax_update()
    {
        Destroy(parallax_array[0]);
        parallax_array[0] = parallax_array[1];
        parallax_array[1] = parallax_array[2];
        AddParallax();
    }

    void AddParallax()
    {

    }
}
