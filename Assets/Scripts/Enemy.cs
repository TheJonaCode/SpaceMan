using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float runningSpeed = 1.5f;

    Rigidbody2D rigidBody;

    public bool facingRight = false;

    private Vector3 startPosition;

    private void Awake(){
        rigidBody = GetComponent<Rigidbody2D>();
        startPosition = this.transform.position;
    }

    void Start(){
        this.transform.position = startPosition;
    }

    private void FixedUpdate(){
        float currentRunningSpeed = runningSpeed;

        if(facingRight){
            //Mirando hacia la derecha
            currentRunningSpeed = runningSpeed;
            this.transform.eulerAngles = new Vector3(0, 180, 0);
        }else{
            //Mirando hacia la izquierda
            //Velocidad en negativo
            currentRunningSpeed = -runningSpeed;
            this.transform.eulerAngles = Vector3.zero;
        }

        if(GameManager.sharedInstance.currentGameState == GameState.inGame){
            rigidBody.velocity = new Vector2(currentRunningSpeed, rigidBody.velocity.y);
        }

    }

}
