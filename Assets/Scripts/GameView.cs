using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Librería UI
using UnityEngine.UI;

public class GameView : MonoBehaviour
{
    public Text coinsText, scoreText, maxScoreText;

    void Start(){
    }

    void Update(){
        if(GameManager.sharedInstance.currentGameState == GameState.inGame){
            int coins = 0;
            float score = 0;
            float maxScore = 0;

            coinsText.text = coins.ToString();
            scoreText.text = "Score: " + score.ToString("f1");
            maxScoreText.text = "Max Score: " + maxScore.ToString("f1");
        }
    }
}