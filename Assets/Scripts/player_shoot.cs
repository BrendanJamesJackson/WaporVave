using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shoot : MonoBehaviour
{
    public int bulletCount;
    public GameObject projectile;
    public Transform gunPos;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletCount = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButtonDown("Fire")) && (bulletCount > 0))
        {
            Instantiate(projectile, gunPos.position, gunPos.rotation);
            bulletCount--;
        }
    }
}
