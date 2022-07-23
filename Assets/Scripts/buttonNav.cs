using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonNav : MonoBehaviour
{
    public void loadGame()
    {
        SceneManager.LoadScene(0);
    }

    public void loadMenu()
    {
        SceneManager.LoadScene(3);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void loadCredits()
    {
        SceneManager.LoadScene(1);
    }
}
