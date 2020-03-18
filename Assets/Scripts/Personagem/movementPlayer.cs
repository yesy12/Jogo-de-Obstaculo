using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementPlayer : MonoBehaviour{
    
    float velocityVeryMinimum = 1;
    float velocityMinimum = 3;
    float velocityNormal = 4.5f;
    float velocityVeryNormal = 5.5f;
    float velocityMaximum = 6;
    float velocityVeryMaximum = 8;
    float velocity;
    float zeroF = 0f;

    // public static bool hitLetterPress;
    // public static bool errorLetterPress;
    public static int point;

    // public int timeSecondsCurrent;
    // public int timeSecondsLimit;

    void Start(){
        setVelocity();
    }

    void Update(){
        setVelocity();
        transform.Translate(velocity* Time.deltaTime,zeroF,zeroF);
    }

    void setVelocity(){
        if(point < 3){
            velocity = velocityVeryMinimum;
        }
        else if(point < 5){
            velocity = velocityMinimum;
        }
        else if(point < 7){
            velocity = velocityNormal;
        }
        else if(point < 9){
            velocity = velocityMaximum;
        }
        else if(point <= 10){
            velocity = velocityVeryMaximum;
        }
        VelocidadePersonagem.texto = velocity.ToString();
    }



}
