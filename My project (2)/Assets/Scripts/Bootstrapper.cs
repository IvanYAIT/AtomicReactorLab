using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private GlobalTimer globalTimer;
    [SerializeField] private GameObject loseScreen;
    [SerializeField] private GameObject gameScreen;
 
    private Game game;
    private void Awake()
    {
        game = new Game(globalTimer, loseScreen, gameScreen);
    }

    void Start()
    {
        game.StartGame();
    }

    public void Restart()
    {
        game.Restart();
    }
}
