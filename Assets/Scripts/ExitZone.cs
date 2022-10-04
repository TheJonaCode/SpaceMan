using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitZone : MonoBehaviour
{

    void Start(){
        
    }

    void Update(){
        
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            LevelManager.sharedInstance.AddLevelBlock();
            LevelManager.sharedInstance.RemoveLevelBlock();
        }
    }
}
