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

    void Update(){
        
    }
}
