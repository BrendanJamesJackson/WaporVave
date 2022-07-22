using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeat_parallax : MonoBehaviour
{
    /*public GameObject[] parallax_array;

    public GameObject parallax_prefab;*/

    public float parallax_offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < - parallax_offset)
        {
            Debug.Log("movestuff");
            MoveStuff();
        }
    }

    void MoveStuff()
    {
        Vector2 temp = new Vector2(parallax_offset * 3f, 0f);
        transform.position = (Vector2)transform.position + temp;
    }

    /*public void parallax_update()
    {
        Destroy(parallax_array[0]);
        parallax_array[0] = parallax_array[1];
        parallax_array[1] = parallax_array[2];
        AddParallax();
    }

    void AddParallax()
    {
        parallax_array[2] = Instantiate(parallax_prefab, parallax_array[1].transform.position + new Vector3(parallax_offset, 0f, 0f), Quaternion.identity);
    }*/
            
}
