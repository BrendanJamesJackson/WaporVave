using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform gunPos;
    public float cooldown = 0.5f;
    private float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if ((Input.GetButtonDown("Fire")) && (timer <= 0))
        {
            Instantiate(projectile, gunPos.position, gunPos.rotation);
            timer = cooldown;
        }
    }
}
