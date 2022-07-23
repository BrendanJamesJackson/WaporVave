using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_shoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform gunPos;
    public float cooldown = 0.5f;
    private float timer;
    private AudioSource sound;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = cooldown;
        sound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if ((Input.GetButtonDown("Fire")) && (timer <= 0))
        {
            Instantiate(projectile, gunPos.position, gunPos.rotation);
            sound.Play();
            timer = cooldown;
        }
    }
}
