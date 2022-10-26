using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Librería UI
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    public Text coinsText, scoreText, maxScoreText;

    private PlayerControler controller;
    void Start(){
        controller = GameObject.Find("Player").GetComponent<PlayerControler>();
    }

    void Update(){
        if(GameManager.sharedInstance.currentGameState == GameState.inGame){
            int coins = GameManager.sharedInstance.collectedObject;
            float score = controller.GetTravelledDistance();
            float maxScore = PlayerPrefs.GetFloat("maxscore", 0);

            coinsText.text = coins.ToString();
            scoreText.text = "Score: " + score.ToString("f1");
            maxScoreText.text = "Max Score: " + maxScore.ToString("f1");
        }
    }
}