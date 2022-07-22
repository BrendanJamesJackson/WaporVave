using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_controller : MonoBehaviour
{
    private int score;
    public GameObject endOverlay;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
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
    }
}
