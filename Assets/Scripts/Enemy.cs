using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int enemyDamage = 10;
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

    private void OnTriggerEnter2D(Collider2D collision){
        GetComponent<AudioSource>().Play();
        if(collision.tag == "Coin"){
            return;
        }
        if(collision.tag == "Player"){
            collision.gameObject.GetComponent<PlayerControler>().CollectHealth(-enemyDamage);
            return;
        }
        //Si enemy impacta con otro elemento, es probable que sea con otro enemigo o elemento de escenario
        facingRight = !facingRight;
    }

}
