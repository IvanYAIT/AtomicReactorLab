using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private Game game;
    private void Awake()
    {
        game = new Game();
    }

    void Start()
    {
        game.StartGame();
    }
}
