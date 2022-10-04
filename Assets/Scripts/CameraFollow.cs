using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    /*Camera*/
    public Vector3 offset = new Vector3(0.2f, 0.0f, -10f);
    public float dampingTime = 0.3f;
    public Vector3 velocity = Vector3.zero;

    void Awake(){
        Application.targetFrameRate = 60;
    }

    void Start(){
        
    }

    void Update(){
        MoveCamera(true);
    }

    public void ResetCameraPosition(){
        MoveCamera(false);
    }

    void MoveCamera(bool smooth){
        Vector3 destination = new Vector3(
            target.position.x -offset.x,
            offset.y,
            offset.z
        );
        if(smooth){
            this.transform.position = Vector3.SmoothDamp(
                /*Donde se encuentra la camara*/
                this.transform.position,
                /*Hacia donde quiere llegar*/
                destination,
                /*Manda la variable y la regresa*/
                ref velocity,
                /*Tiempo*/
                dampingTime
            );
        }else{
            this.transform.position = destination;
        }
    }
}
