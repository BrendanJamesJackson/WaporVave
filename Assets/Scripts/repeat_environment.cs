using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeat_environment : MonoBehaviour
{

    public GameObject[] environments_array;

    public GameObject[] environment_prefab;

    public float environment_offset;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void enviro_update()
    {
        Destroy(environments_array[0]);
        environments_array[0] = environments_array[1];
        environments_array[1] = environments_array[2];
        AddEnvironment();
    }

    void AddEnvironment()
    {
        environments_array[2] = Instantiate(environment_prefab[Random.Range(0,environment_prefab.Length)], environments_array[1].transform.position + new Vector3(environment_offset,0f,0f), Quaternion.identity);
    }
}
