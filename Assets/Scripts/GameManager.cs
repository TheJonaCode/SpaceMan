using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    menu,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour
{
    public GameState currentGameState = GameState.menu;
    
    public static GameManager sharedInstance;

    private PlayerControler controller;

    void Awake(){
        if(sharedInstance == null){
            sharedInstance = this;
        }
    }

    void Start(){
        controller = GameObject.Find("Player").GetComponent<PlayerControler>();
    }

    void Update(){
        if(Input.GetButtonDown("Submit") && currentGameState != GameState.inGame){
            StartGame();
        }
    }

    public void StartGame(){
        SetGameState(GameState.inGame);
    }

    public void GameOver(){
        SetGameState(GameState.gameOver);
    }

    public void BackToMenu(){
        SetGameState(GameState.menu);
    }

    private void SetGameState(GameState newGameState){
        if(newGameState == GameState.menu){
            //TODO: COLOCAR LA LÓGICA DEL MENÚ
        } else if(newGameState == GameState.inGame){
            //TODO: HAY QUE PREPARAR LA ESCENA PARA JUGAR
            LevelManager.sharedInstance.RemoveAllLevelBlocks();
            LevelManager.sharedInstance.GenerateInitialBlocks();
            controller.StartGame();
        } else if(newGameState == GameState.gameOver){
            //TODO: PREPARAR EL JUEGO PARA EL GAME OVER
        }

        this.currentGameState = newGameState;
    }

}
