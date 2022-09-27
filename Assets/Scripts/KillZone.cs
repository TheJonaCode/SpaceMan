using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            PlayerControler controller = collision.GetComponent<PlayerControler>();
            controller.Die();
        }
    }
}
