using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public static MenuManager sharedInstance;
    public Canvas menuCanvas;
    public Canvas gameCanvas;
    public Canvas gameOverCanvas;

    private void Awake(){
        if(sharedInstance == null){
            sharedInstance = this;
        }
    } 

    //CANVAS
    //Menu
    public void ShowMainMenu(){
        gameOverCanvas.enabled = true;
        //menuCanvas.enabled = true;
        //gameCanvas.enabled = false;
        //gameOverCanvas.enabled = false;
    }
    public void HideCanvas(){
        gameCanvas.enabled = false;
        gameOverCanvas.enabled = false;
    }

    //Game
    public void ShowGameCanvas(){
        gameCanvas.enabled = true;
        menuCanvas.enabled = false;
        gameOverCanvas.enabled = false;
    }

    //GameOver
    public void ShowGameOver(){
        gameOverCanvas.enabled = true;
        menuCanvas.enabled = false;
        gameCanvas.enabled = false;
    }


    public void ExitGame(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    void Start(){
        
    }

    void Update(){
        
    }
}
