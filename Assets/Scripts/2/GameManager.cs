using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState
{
    Menu,
    InGame,
    GameOver
}

public class GameManager : MonoBehaviour
{
    public int vidaInicial = 10;
    public int vida;




    //this is the default valu of our GameManeger
    public GameState currentGameState = GameState.InGame;

    static GameManager instance;

    private void Awake()
    {
        //"this" means the object that unity create
        instance = this;
    }

    private void Start()
    {
        currentGameState = GameState.Menu;
    }

    public static GameManager GetInstance()
    {
        return instance;
    }

    public void StartGame()
    {
        PlayerController.GetInstance().StartGame();
        vida = vidaInicial; 

        ChangeGameState(GameState.InGame);
    }

    private void Update()
    {
        if (currentGameState != GameState.InGame && Input.GetKeyDown(KeyCode.X))
        {
            
            ChangeGameState(GameState.InGame);
            StartGame();
        }
    }

    // Starts our game
    

    // Called when player dies
    public void GameOver()
    {
        ChangeGameState(GameState.GameOver);
        print("EL Juego ha terminado, has muerto");
    }


    public void BackToMainMenu()
    {
        ChangeGameState(GameState.Menu);
    }

    void ChangeGameState(GameState newGameState)
    {
        /*
        if (newGameState == GameState.Menu)
        {
            //Load Mainmenu scene
        }
        else if (newGameState == GameState.InGame)
        {
            //Unity loads the Game
        }
        else if (newGameState == GameState.GameOver)
        {
            //Loads the end of the game scene
        }
        */

        switch (newGameState)
        {
            case GameState.Menu:
                //Load Mainmenu scene
                break;

            case GameState.InGame:
                //Unity loads the Game
                break;

            case GameState.GameOver:
                //Loads the end of the game scene
                break;
            default:
                currentGameState = GameState.Menu;
                break;
        }




        currentGameState = newGameState;
    }
}
