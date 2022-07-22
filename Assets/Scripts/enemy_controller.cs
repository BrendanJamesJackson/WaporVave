using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_controller : MonoBehaviour
{
    public int points;
    private game_controller gc;
    private int type;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enemyDie()
    {
        gc.incScore(points);
        //particle effect
        //sound
        Destroy(gameObject);
    }
}
