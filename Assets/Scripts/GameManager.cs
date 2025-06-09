using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Lvl1()
    {
        SceneManager.LoadScene("Lvl 1");
    }
    public void Lvl2()
    {
        SceneManager.LoadScene("Lvl 2");
    }
}
