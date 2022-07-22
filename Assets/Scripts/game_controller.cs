using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_controller : MonoBehaviour
{
    public float speedmodifier;

    private int score;
    public GameObject endOverlay;

    protected float Timer;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        speedmodifier = 1;
    }

    public float getSpeedModifier()
    {
        return speedmodifier;
    }

    private void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= 10f)
        {
            Timer = 0f;
            speedmodifier += 0.1f;
        }
    }

    public int getScore()
    {
        return score;
    }

    public void incScore(int points)
    {
        score += points;
    }

    public void gameOver()
    {
        //game over sequence - Dan
        //play some sound
        endOverlay.SetActive(true);
        speedmodifier = 0f;
    }
}
