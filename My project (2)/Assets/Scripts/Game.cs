using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game
{
    private GlobalTimer timer;
    private GameObject loseScreen;
    private GameObject gamescreen;
    public Game(GlobalTimer timer, GameObject loseScreen, GameObject gamescreen)
    {
        this.timer = timer;
        this.loseScreen = loseScreen;
        this.gamescreen = gamescreen;
    }

    public void StartGame()
    {
        timer.StartTimer();
        ResourceButton.OnPlayerLose += EndGame;
    }
    private void EndGame()
    {
        loseScreen.SetActive(true);
        gamescreen.SetActive(false);
        timer.StopTimer();
        ResourceButton.OnPlayerLose -= EndGame;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0); 
    }
}
